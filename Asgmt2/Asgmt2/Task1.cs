using System;


namespace Asgmt2
{
    public delegate void Action();

    class FiniteStateTable
    {
        public cell_FST[,] FST;

        //variables 
            public struct cell_FST { 
            public int next_state;
            public Action action;
        };

        private const int num_events = 5;
        private const int num_states = 5;
        

        // Methods
        private void SetNextState(int eventIndex, int stateIndex, int nextState) {
            FST[eventIndex, stateIndex].next_state = nextState;
        }
        public void SetActions(int eventIndex, int stateIndex, Action nextAction) {
            FST[eventIndex, stateIndex].action = nextAction;
        }
        public int GetNextState(int eventIndex, int stateIndex) {
           return FST[eventIndex, stateIndex].next_state;
        }
        public Action GetActions(int eventIndex, int stateIndex) {
            return FST[eventIndex, stateIndex].action;
        }

        // Constructor
        public FiniteStateTable()
        {
            FST = new cell_FST[num_events, num_states]; // Finite State Table
        }


        static void Main(string[] args)
        {
       
        }
    }
}
