#if defined (__USE_LPCOPEN)
#include "chip.h"
#endif

#include <cr_section_macros.h>
#include "Can_Controller.h"
#define TEST_CCAN_BAUD_RATE 250000

bool inp_value;
bool out_value;
uint32_t CanApiClkInitTable[2];
uint16_t systick;
void SysTick_Handler(void){

}
void TIMER32_0_IRQHandler(void){
	Chip_GPIO_SetPinToggle(LPC_GPIO, 1, 8);
}

/*	CAN receive callback */
/*	Function is executed by the Callback handler after
    a CAN message has been received */
void CAN_rx(uint8_t msg_obj_num) {
	    received_signal.msgobj = msg_obj_num;
	    LPC_CCAN_API->can_receive(&received_signal);
		Chip_GPIO_SetPinToggle(LPC_GPIO, 0, 8);

}
/*	CAN transmit callback */
/*	Function is executed by the Callback handler after
    a CAN message has been transmitted */
void CAN_tx(uint8_t msg_obj_num) {

	Chip_GPIO_SetPinToggle(LPC_GPIO, 1, 5);
}

/*	CAN error callback */
/*	Function is executed by the Callback handler after
    an error has occured on the CAN bus */
void CAN_error(uint32_t error_info) {}

/**
 * @brief	CCAN Interrupt Handler
 * @return	Nothing
 * @note	The CCAN interrupt handler must be provided by the user application.
 *	It's function is to call the isr() API located in the ROM
 */
void CAN_IRQHandler(void) {


	LPC_CCAN_API->isr();
}


int main(void) {


	  CCAN_CALLBACKS_T callbacks = {
	    CAN_rx,
	 	CAN_tx,
	 	CAN_error,
	 	NULL,
	 	NULL,
	 	NULL,
	 	NULL,
	 	NULL,
	   };
	  SystemCoreClockUpdate();

	  baudrateCalculate(TEST_CCAN_BAUD_RATE, CanApiClkInitTable);
	  LPC_CCAN_API->init_can(&CanApiClkInitTable[0], TRUE);//CanApiClkInitTable sor
	/* Configure the CAN callback functions */
	  LPC_CCAN_API->config_calb(&callbacks);
	  	/* Enable the CAN Interrupt */
	  NVIC_EnableIRQ(CAN_IRQn);
	  SysTick_Config(1);
	  Chip_GPIO_Init(LPC_GPIO);
	  Init_Pinmux();
	  //Init_PWM();
	  SetModePWM();
	  Analog_Setup();
	  set_up_msg();
	  Send_Msg(0x504, 0x1FFFFFFF, 2, 3, 4, 5, 6, 7, 8, 9);
      //TIM_Init();

    while(1) {
    	inp_value=getInput(INP2);
    	out_value=getOutp(OUT1);

    	INP_send_status();
    	for(int i =0;i<1000000;i++);
    	pot_send_data();
    	Chip_GPIO_SetPinToggle(LPC_GPIO, 0, 6);
        for(int i =0;i<1000000;i++);




    }

}
