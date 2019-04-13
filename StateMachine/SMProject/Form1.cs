using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;

namespace AutomataTheory
{
    public partial class Form1 : Form
    {
        Model stateModel;
        List<StateDataGridRow> StateDataGridSource = new List<StateDataGridRow>();
        readonly string ErrorPath = "Исходный файл имеет неверный формат.";

        public Form1(Model machine)
        {
            stateModel = machine;
            InitializeComponent();

            stateModel.OnChanged += (sm) =>
            {
                textBoxFinalStates.Text = "";
                foreach (var st in sm.FinalStates)
                    textBoxFinalStates.Text += st + Environment.NewLine;

                textBoxTrace.Text = sm.ExecutionTrace;

                textBoxStartState.Text = sm.StartState;

                StateDataGridSource = sm.StateRules.SelectMany(state => state.Value
                    .Select(record => new StateDataGridRow(state.Key, record.Key, record.Value)))
                    .ToList();

                textBoxResult.Text = sm.Result;

                RefreshGrid();
            };
        }

        /// <summary>
        /// Создание столбцов таблицы переходов
        /// </summary>
        public void GridHeaders()
        {
            dataGridViewRules.Columns.Add(new DataGridViewTextBoxColumn
            {
                Width = 70,
                DataPropertyName = "State",
                HeaderText = "Состояние"
            });
            dataGridViewRules.Columns.Add(new DataGridViewTextBoxColumn
            {
                Width = 70,
                DataPropertyName = "Symbol",
                HeaderText = "Условие"
            });
            dataGridViewRules.Columns.Add(new DataGridViewTextBoxColumn
            {
                Width = 80,
                DataPropertyName = "NextState",
                HeaderText = "Следующее Состояние"
            });
        }

        /// <summary>
        /// Проверка слова на допустимость конечным автоматом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckString_Click(object sender, EventArgs e)
        {
            stateModel.CheckWord(textBoxWord.Text);
        }

        /// <summary>
        /// Добавление правила перехода в КА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddRule_Click(object sender, EventArgs e)
        {
            if (!char.TryParse(textBoxCondition.Text.ToString(), out char symbol))
            {
                MessageBox.Show("\"Символ\" перехода должен состоять из одного символа");
                return;
            }
            string state = textBoxName.Text;
            string nextst = textBoxNextState.Text;
            stateModel.AddRule(state, symbol, nextst);
            RefreshGrid();
        }

        /// <summary>
        /// Обновление источника данных и самого элемента DataGridViewRules
        /// </summary>
        private void RefreshGrid()
        {
            dataGridViewRules.DataSource = null;
            GridHeaders();
            dataGridViewRules.DataSource = StateDataGridSource;
            dataGridViewRules.Refresh();
        }

        /// <summary>
        /// Выбор начального состояния КА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChooseStartState_Click(object sender, EventArgs e) =>
            stateModel.ChangeStartState(textBoxStartState.Text.Trim());

        /// <summary>
        /// Обработчик добавления заключительного состояния в КА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddFinalState_Click(object sender, EventArgs e) =>
            stateModel.AddFinalState(textBoxFinal.Text.Trim());

        /// <summary>
        /// Обработчик удаления всех заключительных состояний КА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearFinalStates_Click(object sender, EventArgs e) =>
            stateModel.ClearFinalStates();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        /// <summary>
        /// Обработчик изменения названия начального состояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxStartState_TextChanged(object sender, EventArgs e) =>
            stateModel.ChangeStartState(textBoxStartState.Text);

        /// <summary>
        /// Загрузка КА из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = openFileDialogSaveLoad.ShowDialog();
            if(res == DialogResult.OK)
            {
                if (!DeserializeFile(openFileDialogSaveLoad.FileName))
                    MessageBox.Show(ErrorPath);
            }
        }

        /// <summary>
        /// Метод десериализации КА из файла json, лежащего по пути <paramref name="path"/>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool DeserializeFile(string path)
        {
            FileStream stream = null;
            try
            {
                var serj = new DataContractJsonSerializer(typeof(StateMachine));
                using (stream = new FileStream(path, FileMode.OpenOrCreate))
                    stateModel.StateMachine = (StateMachine)serj.ReadObject(stream);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                stream?.Close();
            }
            return true;
        }

        /// <summary>
        /// Метод сериализации КА в файл json по пути path
        /// </summary>
        /// <returns></returns>
        private bool SerializeFile(string path)
        {
            FileStream stream = null;
            try
            {
                var serj = new DataContractJsonSerializer(typeof(StateMachine));
                serj.WriteObject(stream, stateModel.StateMachine);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                stream?.Close();
            }
            return true;
        }

        /// <summary>
        /// Обновление таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTableToolStripMenuItem_Click(object sender, EventArgs e) => RefreshGrid();

        /// <summary>
        /// Очистка правил переходов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTableToolStripMenuItem_Click(object sender, EventArgs e) => stateModel.ClearRules();

        /// <summary>
        /// Сохранение КА в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = openFileDialogSaveLoad.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (!SerializeFile(openFileDialogSaveLoad.FileName))
                    MessageBox.Show(ErrorPath);
            }
        }
    }

    /// <summary>
    /// Строка DataGridView для отображения функции перехода
    /// </summary>
    public class StateDataGridRow
    {
        public string State { get; set; }
        public char Symbol { get; set; }
        public string NextState { get; set; }

        public StateDataGridRow(string state, char symbol, string nextState)
        {
            State = state;
            Symbol = symbol;
            NextState = nextState;
        }
    }
}