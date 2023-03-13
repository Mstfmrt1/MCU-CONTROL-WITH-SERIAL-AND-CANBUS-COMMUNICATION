#ifndef CAN_CONTROLLER_H_
#define CAN_CONTROLLER_H_

#if defined (__USE_LPCOPEN)
#if defined(NO_BOARD_LIB)
#include "chip.h"
#else
#include "board.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <cr_section_macros.h>
#endif
#endif


#define CAN_BAUD_RATE 250000
#define TICKRATE_HZ1 (10)
#define TICKRATE_HZ2 (11)
#define T0MR0          (*((volatile unsigned long *) 0x40014014))
#define T0TC          (*((volatile unsigned long *) 0x40014008))

static ADC_CLOCK_SETUP_T ADCSetup;

CCAN_MSG_OBJ_T INP;
CCAN_MSG_OBJ_T temperature;
CCAN_MSG_OBJ_T pot;
CCAN_MSG_OBJ_T ledstatus;
CCAN_MSG_OBJ_T send_msg;
CCAN_MSG_OBJ_T received_signal;

typedef enum _BUTTON_STATUS
{
  NO_DATA=-1,
  RELEASED,
  PRESSED,


}button_status;
typedef enum _OUTPUTS
{
	OUT1,//PIO0_6
	OUT2,//PIO0_8
	OUT3,//PIO1_5
	OUT4,//PIO1_8

}output;
typedef enum _INPUTS
{
	INP1,//PIO0_2 BUTTON
	INP2,//PIO3_2
	INP3,//ANO PIO0_11 POT


}INPUT;


/*extern void CAN_rx(uint8_t Rx ){}
extern void CAN_tx(uint8_t Tx){}
extern void CAN_error(uint32_t Error ){}
extern void CAN_IRQHandler(void){}
extern void SysTick_Handler(void){}
extern void TIMER32_0_IRQHandler(void){}*/




void TIM_Init()

{
	uint32_t timerFreq;
	/* Enable and setup SysTick Timer at a periodic rate */
	SysTick_Config(SystemCoreClock / TICKRATE_HZ1);
	/* Enable timer 1 clock */
	Chip_TIMER_Init(LPC_TIMER32_0);
	/* Timer rate is system clock rate */
	timerFreq = Chip_Clock_GetSystemClockRate();
	/* Timer setup for match and interrupt at TICKRATE_HZ */
	Chip_TIMER_Reset(LPC_TIMER32_0);
	Chip_TIMER_MatchEnableInt(LPC_TIMER32_0, 1);
	Chip_TIMER_SetMatch(LPC_TIMER32_0, 1, (timerFreq / TICKRATE_HZ2));
	Chip_TIMER_ResetOnMatchEnable(LPC_TIMER32_0, 1);
	Chip_TIMER_Enable(LPC_TIMER32_0);

	/* Enable timer interrupt */
	NVIC_ClearPendingIRQ(TIMER_32_0_IRQn);
	NVIC_EnableIRQ(TIMER_32_0_IRQn);



}
void Delay(int Ms){
    /* Timer rate is system clock rate */
    uint32_t timerFreq = Chip_Clock_GetSystemClockRate();
    uint32_t CurrentTime;
    /* Timer setup for match and interrupt at TICKRATE_HZ */
    //Chip_TIMER_Reset(LPC_TIMER32_0);
    Chip_TIMER_MatchEnableInt(LPC_TIMER32_0, 0);
    CurrentTime = T0TC;
    Chip_TIMER_SetMatch(LPC_TIMER32_0, 0, CurrentTime+Ms*(timerFreq / 1000));
    Chip_TIMER_MatchEnableInt(LPC_TIMER32_0, 0);
    Chip_TIMER_Enable(LPC_TIMER32_0);
    while(((T0MR0)&(0x01))==0x01);
    //Chip_TIMER_Disable(LPC_TIMER32_0);
    //Chip_TIMER_Reset(LPC_TIMER32_0);

}
void Analog_Setup(void)//potentiometer read
{
	  Chip_ADC_Init(LPC_ADC, &ADCSetup);
	  Chip_ADC_SetSampleRate(LPC_ADC, &ADCSetup,ADC_MAX_SAMPLE_RATE/10);
	  Chip_ADC_SetResolution(LPC_ADC, &ADCSetup,ADC_10BITS);
	  Chip_ADC_SetBurstCmd(LPC_ADC, ENABLE);

}
uint16_t getAnalog(INPUT inputNumber)
{

	uint16_t finalAdcReading=0;
	uint16_t finalAdcReadingCnt=0,i=0;
	uint16_t adcRead[2]={0,0};



	switch(inputNumber){
	case INP1:
		break;
	case INP2:
		break;
	case INP3:
		Chip_ADC_EnableChannel(LPC_ADC, ADC_CH0, ENABLE);
	    Chip_ADC_SetStartMode(LPC_ADC, ADC_START_NOW, ADC_TRIGGERMODE_RISING);
	    while (Chip_ADC_ReadStatus(LPC_ADC, ADC_CH0, ADC_DR_DONE_STAT) != SET) {}//wait for end of conversion

	    if(!Chip_ADC_ReadValue(LPC_ADC, ADC_CH0, &adcRead[i]))
	    	 adcRead[i]=0xFF;
	    else{
	    	finalAdcReading=adcRead[i];
	    	finalAdcReadingCnt++;}
	    break;

	}
	Chip_ADC_EnableChannel(LPC_ADC, ADC_CH0, DISABLE);


	return finalAdcReading;

}

void Init_Pinmux()//PINMUX SETTINGS
{
	Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO0_2 , IOCON_MODE_PULLUP, FUNC0);//GPIO INP FUNCTION BUTTON
    Chip_GPIO_SetPinDIRInput(LPC_GPIO, 0, 2);

	Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO3_2 , IOCON_MODE_PULLUP, FUNC0);//GPIO INP FUNCTION
    Chip_GPIO_SetPinDIRInput(LPC_GPIO, 3, 2);

    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO0_11 , IOCON_MODE_INACT|IOCON_ADMODE_EN, FUNC2);//A/D FUNCTION
	Chip_GPIO_SetPinDIRInput(LPC_GPIO, 0, 11);  //    AIN3,


    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO1_5 , IOCON_MODE_INACT, FUNC0);
    Chip_GPIO_SetPinDIROutput(LPC_GPIO, 1, 5);

    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO2_11 , IOCON_MODE_INACT, FUNC0);
    Chip_GPIO_SetPinDIROutput(LPC_GPIO, 2, 11);


    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO1_8 , IOCON_MODE_INACT, FUNC0);
    Chip_GPIO_SetPinDIROutput(LPC_GPIO, 1, 8);


    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO0_8 , IOCON_MODE_INACT, FUNC0);
    Chip_GPIO_SetPinDIROutput(LPC_GPIO, 0, 8);

    Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO0_6 , IOCON_MODE_INACT, FUNC0);
    Chip_GPIO_SetPinDIROutput(LPC_GPIO, 0, 6);


}

bool getOutp(output outputNumber)
{
	bool status=false;
	switch(outputNumber){
	case OUT1:
		status=Chip_GPIO_GetPinState(LPC_GPIO,0,6);
	    break;
    case OUT2:
    	status=Chip_GPIO_GetPinState(LPC_GPIO,0,8);
	    break;
	case OUT3:
		status=Chip_GPIO_GetPinState(LPC_GPIO,1,5);
	    break;
	case OUT4:
			status=Chip_GPIO_GetPinState(LPC_GPIO,1,8);
		    break;

	}
	return status;
}

bool getInput(INPUT inputNumber)
{

	switch(inputNumber){
	case INP1:
		return Chip_GPIO_GetPinState(LPC_GPIO,0,2);
	    break;

	case INP2:
		return Chip_GPIO_GetPinState(LPC_GPIO,3,2);
	    break;

	default:
	    return 0;
	    break;
	}
}


void SetModePWM()
{
	Chip_IOCON_PinMux(LPC_IOCON, IOCON_PIO3_3 , IOCON_MODE_PULLDOWN, IOCON_FUNC2 | (0x1 << 6)| (0x1 << 7));
}

STATIC INLINE void Chip_TIMER_PWMWrite(LPC_TIMER_T *pTMR, uint32_t pwmval)
{
    pTMR->PWMC = pwmval;
}

STATIC INLINE uint32_t Chip_TIMER_PWMRead(LPC_TIMER_T *pTMR)
{
    return pTMR->PWMC;
}

void Init_PWM(void)
{
	uint16_t OnResetValue=3600;
	uint16_t prescaler=512;



	LPC_TIMER16_0->EMR = (1<<0)|(1<<1)|(1<<3)|(1<<5)|(1<<10);

  /* Setup Timer for PWM */
    Chip_TIMER_Init(LPC_TIMER16_0);
    // MR3 reset
    Chip_TIMER_ResetOnMatchEnable(LPC_TIMER16_0, 3);
    // Set the frequency prescaler for the timer
    Chip_TIMER_PrescaleSet(LPC_TIMER16_0, prescaler-1);
    // Set MR3 value for resetting the timer
    Chip_TIMER_SetMatch(LPC_TIMER16_0, 3, OnResetValue);
    // Set PWM Control Register
    Chip_TIMER_PWMWrite(LPC_TIMER16_0,(1<<0 | 1<<1 | 1<<2 | 1<<3 ));
    // Enable Timer16_0
    Chip_TIMER_Enable(LPC_TIMER16_0);


    Chip_TIMER_Init(LPC_TIMER32_0);
}

void baudrateCalculate(uint32_t baud_rate, uint32_t *can_api_timing_cfg)
{
	uint32_t pClk, div, quanta, segs, seg1, seg2, clk_per_bit, can_sjw;
	Chip_Clock_EnablePeriphClock(SYSCTL_CLOCK_CAN);
	pClk = Chip_Clock_GetMainClockRate();

	clk_per_bit = pClk / baud_rate;

	for (div = 0; div <= 15; div++) {
		for (quanta = 1; quanta <= 32; quanta++) {
			for (segs = 3; segs <= 17; segs++) {
				if (clk_per_bit == (segs * quanta * (div + 1))) {
					segs -= 3;
					seg1 = segs / 2;
					seg2 = segs - seg1;
					can_sjw = seg1 > 3 ? 3 : seg1;
					can_api_timing_cfg[0] = div;
					can_api_timing_cfg[1] =
						((quanta - 1) & 0x3F) | (can_sjw & 0x03) << 6 | (seg1 & 0x0F) << 8 | (seg2 & 0x07) << 12;
					return;
				}
			}
		}
	}
}
void Send_Msg(uint32_t _mode_id,uint32_t  _mask,uint8_t b0,uint8_t b1,uint8_t b2,uint8_t b3,uint8_t b4,uint8_t b5,uint8_t b6,uint8_t b7)
{
	send_msg.mode_id=_mode_id;
	send_msg.mask=_mask;
	send_msg.dlc=8;
	send_msg.data[0]=b0;
	send_msg.data[1]=b1;
	send_msg.data[2]=b2;
	send_msg.data[3]=b3;
	send_msg.data[4]=b4;
	send_msg.data[5]=b5;
	send_msg.data[6]=b6;
	send_msg.data[7]=b7;
	send_msg.msgobj=6;

	LPC_CCAN_API->can_transmit(&send_msg);
}


void set_up_msg()
{
temperature.mode_id=0x500;           pot.mode_id=0x501;
temperature.mask=0x1FFFFFFF;         pot.mask=0x1FFFFFFF;
temperature.dlc=5; 					 pot.dlc=8;
temperature.msgobj=2;                pot.msgobj=3;


INP.mode_id=0x502;		         ledstatus.mode_id=0x503;
INP.mask=0x1FFFFFFF;		     ledstatus.mask=0x1FFFFFFF;
INP.dlc=2;				         ledstatus.dlc=1;
INP.msgobj=4;				     ledstatus.msgobj=5;

//received messsage
received_signal.mode_id=0x600;
received_signal.mask=0x1FFFFFFF;
received_signal.dlc=8;

LPC_CCAN_API->config_rxmsgobj(&received_signal);

}

void INP_send_status()
{
	if(getInput(INP1))
		INP.data[0]=PRESSED;

	else if(getInput(INP2))
	 INP.data[0]=RELEASED;
     INP.data[1]=getInput(INP2);
	 LPC_CCAN_API->can_transmit(&INP);
	 __WFI();

}
void pot_send_data()
{
	uint16_t adc_value=getAnalog(INP3);
	if(adc_value!=0xFF)

		pot.data[0]=adc_value;
		LPC_CCAN_API->can_transmit(&pot);
    __WFI();

}




#endif


