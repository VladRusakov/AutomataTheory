using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomataTheory
{
    /// <summary>
    /// Представляет модель паттерна MVC
    /// </summary>
    public class Model
    {
        StateMachine sm;
        public StateMachine StateMachine
        {
            get => sm;
            set
            {
                sm = value;
                OnChange?.Invoke(sm);
            }
        }

        private event Action<StateMachine> OnChange;

        public event Action<StateMachine> OnChanged
        {
            add => OnChange += value;
            remove => OnChange -= value;
        }

        public Model()
        {
            sm = new StateMachine();
        }

        public void AddRule(string state, char symbol, string nextState)
        {
            sm.AddRule(state, symbol, nextState);
            OnChange?.Invoke(sm);
        }

        public void ClearRules()
        {
            sm.ClearRules();
            OnChange?.Invoke(sm);
        }
        
        public void AddFinalState(string state)
        {
            sm.AddFinalState(state);
            OnChange?.Invoke(sm);
        }

        public void ClearFinalStates()
        {
            sm.ClearFinalStates();
            OnChange?.Invoke(sm);
        }

        public void ChangeStartState(string state)
        {
            sm.StartState = state;
            OnChange?.Invoke(sm);
        }

        public void CheckWord(string word)
        {
            sm.CheckWord(word);
            OnChange?.Invoke(sm);
        }
    }
}