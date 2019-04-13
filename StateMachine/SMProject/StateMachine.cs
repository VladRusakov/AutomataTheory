using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AutomataTheory
{
    /// <summary>
    /// Класс, представляющий конечный автомат
    /// </summary>
    [DataContract]
    public class StateMachine
    {
        static readonly string ErrorRuleNotExist = "Не существует правила перехода.";
        static readonly string ResultAllowable = "Цепочка допустима.";
        static readonly string ResultUnallowable = "Цепочка недопустима.";

        public string Result { get; private set; }
        private string startState = "";
        [DataMember]
        public HashSet<string> FinalStates { get; private set; } 
            = new HashSet<string>(); //множество заключительных состояний
        [DataMember]
        public string StartState
        {
            get => startState;
            set => startState = value;
        }

        public string ExecutionTrace { get; private set; } = ""; // строка вывода тактов работы КА

        // Функции переходов
        [DataMember]
        public Dictionary<string, Dictionary<char, string>> StateRules { get; private set; } =
                new Dictionary<string, Dictionary<char, string>>();

        public StateMachine() { }

        /// <summary>
        /// Проверить слово <paramref name="word"/> на допустимость данным конечным автоматом
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public void CheckWord(string word)
        {
            string state = StartState;
            Result = "";
            ExecutionTrace = "";
            int i = 1;
            foreach (char symbol in word)
            {
                if (StateRules.Keys.Contains(state) && StateRules[state].Keys.Contains(symbol))
                {
                    ExecutionTrace += i++.ToString() + ") (" + state + ", " + symbol + 
                        ") -> " + StateRules[state][symbol] + Environment.NewLine;
                    state = StateRules[state][symbol];
                }
                else
                {
                    ExecutionTrace += ErrorRuleNotExist;
                    Result = ResultUnallowable;
                    return;
                }
            }
            Result =  FinalStates.Contains(state) ? ResultAllowable : ResultUnallowable;
        }

        /// <summary>
        /// Добавить правило перехода из состояния <paramref name="state"/> по символу
        /// <paramref name="symbol"/> в состояние <paramref name="nextState"/>
        /// </summary>
        /// <param name="s"></param>
        public void AddRule(string state, char symbol, string nextState)
        {
            if (!StateRules.Keys.Contains(state))
                StateRules[state] = new Dictionary<char, string>();

            StateRules[state][symbol] = nextState;
        }

        /// <summary>
        /// Очистить функции переходов
        /// </summary>
        public void ClearRules() => StateRules.Clear();

        /// <summary>
        /// Добавить состояние <paramref name="state"/> в список заключительных
        /// </summary>
        /// <param name="state"></param>
        public void AddFinalState(string state) => FinalStates.Add(state);

        /// <summary>
        /// Очистить список заключительных состояний
        /// </summary>
        public void ClearFinalStates() => FinalStates.Clear();
    }
}
