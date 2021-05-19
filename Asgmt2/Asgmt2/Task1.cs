using System;


namespace Asgmt2
{
    public delegate void Action(); // Declare delegate. 

    class FiniteStateTable
    {
        // Declare 2D struct array.
        public cell_FST[,] FST;

        // Variables 
        
        // Declare struct
            public struct cell_FST { 
            public int next_state; // Index to the next state.
            public Action action;  // Associated transition action.
        };

        // Declare constants for intialising FST array size.
        private const int num_events = 5;
        private const int num_states = 5;
        

        // Methods

        // Access and update the index to the next state in the indexed FST array position.
        private void SetNextState(int eventIndex, int stateIndex, int nextState) {
            FST[eventIndex, stateIndex].next_state = nextState;
        }

        // Access and update the associated transistion action in the indexed FST array position.
        public void SetActions(int eventIndex, int stateIndex, Action nextAction) {
            FST[eventIndex, stateIndex].action = nextAction;
        }

        // Return the index to the next state in the indexed FST array position.
        public int GetNextState(int eventIndex, int stateIndex) {
           return FST[eventIndex, stateIndex].next_state;
        }

        // Return the associated transistion action in the indexed FST array position.
        public Action GetActions(int eventIndex, int stateIndex) {
            return FST[eventIndex, stateIndex].action;
        }

        // Constructor
        public FiniteStateTable()
        {
            FST = new cell_FST[num_events, num_states]; // Intialise new instance of Finite State Table array.
        }


        static void Main(string[] args)
        {
       
        }
    }
}
