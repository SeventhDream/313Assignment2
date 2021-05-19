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
            public int next_state;
            public Action action;
        };

        // Declare constants for intialising FST array size.
        private const int num_events = 5;
        private const int num_states = 5;
        

        // Methods

        // Access and update the indexed struct's "next state" field in FST array.
        private void SetNextState(int eventIndex, int stateIndex, int nextState) {
            FST[eventIndex, stateIndex].next_state = nextState;
        }

        // Access and update the indexed struct's "Action" delegate field in FST array.
        public void SetActions(int eventIndex, int stateIndex, Action nextAction) {
            FST[eventIndex, stateIndex].action = nextAction;
        }

        // Access and return the indexed struct's "next state" field in FST array.
        public int GetNextState(int eventIndex, int stateIndex) {
           return FST[eventIndex, stateIndex].next_state;
        }
        // Access and return the indexed struct's "Action" delegate field in FST array.
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
