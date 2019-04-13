namespace AutomataTheory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTrace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckString = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.textBoxNextState = new System.Windows.Forms.TextBox();
            this.buttonAddCoFA = new System.Windows.Forms.Button();
            this.textBoxStartState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFinalStates = new System.Windows.Forms.TextBox();
            this.buttonAddFinSt = new System.Windows.Forms.Button();
            this.buttonClearFinSt = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogSaveLoad = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Location = new System.Drawing.Point(324, 149);
            this.dataGridViewRules.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.dataGridViewRules.Size = new System.Drawing.Size(355, 372);
            this.dataGridViewRules.TabIndex = 0;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(12, 59);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(132, 22);
            this.textBoxWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входная цепочка";
            // 
            // textBoxTrace
            // 
            this.textBoxTrace.Location = new System.Drawing.Point(12, 118);
            this.textBoxTrace.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTrace.Multiline = true;
            this.textBoxTrace.Name = "textBoxTrace";
            this.textBoxTrace.ReadOnly = true;
            this.textBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrace.Size = new System.Drawing.Size(132, 330);
            this.textBoxTrace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Такты работы КА";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 472);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(132, 48);
            this.textBoxResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вывод";
            // 
            // CheckString
            // 
            this.CheckString.Location = new System.Drawing.Point(153, 56);
            this.CheckString.Margin = new System.Windows.Forms.Padding(4);
            this.CheckString.Name = "CheckString";
            this.CheckString.Size = new System.Drawing.Size(156, 25);
            this.CheckString.TabIndex = 7;
            this.CheckString.Text = "Проверить цепочку";
            this.CheckString.UseVisualStyleBackColor = true;
            this.CheckString.Click += new System.EventHandler(this.CheckString_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Добавить условие перехода состояния КА";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Состояние";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Условие";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Следующее состояние";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(335, 79);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(76, 22);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(425, 79);
            this.textBoxCondition.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(67, 22);
            this.textBoxCondition.TabIndex = 14;
            // 
            // textBoxNextState
            // 
            this.textBoxNextState.Location = new System.Drawing.Point(505, 79);
            this.textBoxNextState.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNextState.Name = "textBoxNextState";
            this.textBoxNextState.Size = new System.Drawing.Size(174, 22);
            this.textBoxNextState.TabIndex = 15;
            // 
            // buttonAddCoFA
            // 
            this.buttonAddCoFA.Location = new System.Drawing.Point(324, 118);
            this.buttonAddCoFA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCoFA.Name = "buttonAddCoFA";
            this.buttonAddCoFA.Size = new System.Drawing.Size(355, 28);
            this.buttonAddCoFA.TabIndex = 17;
            this.buttonAddCoFA.Text = "Добавить условие перехода состояния КА";
            this.buttonAddCoFA.UseVisualStyleBackColor = true;
            this.buttonAddCoFA.Click += new System.EventHandler(this.ButtonAddRule_Click);
            // 
            // textBoxStartState
            // 
            this.textBoxStartState.Location = new System.Drawing.Point(153, 118);
            this.textBoxStartState.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartState.Name = "textBoxStartState";
            this.textBoxStartState.Size = new System.Drawing.Size(156, 22);
            this.textBoxStartState.TabIndex = 20;
            this.textBoxStartState.TextChanged += new System.EventHandler(this.TextBoxStartState_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Начальное состояние";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(153, 187);
            this.textBoxFinal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(156, 22);
            this.textBoxFinal.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Конечные состояния";
            // 
            // textBoxFinalStates
            // 
            this.textBoxFinalStates.Location = new System.Drawing.Point(153, 250);
            this.textBoxFinalStates.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFinalStates.Multiline = true;
            this.textBoxFinalStates.Name = "textBoxFinalStates";
            this.textBoxFinalStates.ReadOnly = true;
            this.textBoxFinalStates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFinalStates.Size = new System.Drawing.Size(156, 245);
            this.textBoxFinalStates.TabIndex = 24;
            // 
            // buttonAddFinSt
            // 
            this.buttonAddFinSt.Location = new System.Drawing.Point(152, 214);
            this.buttonAddFinSt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddFinSt.Name = "buttonAddFinSt";
            this.buttonAddFinSt.Size = new System.Drawing.Size(159, 28);
            this.buttonAddFinSt.TabIndex = 25;
            this.buttonAddFinSt.Text = "Добавить";
            this.buttonAddFinSt.UseVisualStyleBackColor = true;
            this.buttonAddFinSt.Click += new System.EventHandler(this.ButtonAddFinalState_Click);
            // 
            // buttonClearFinSt
            // 
            this.buttonClearFinSt.Location = new System.Drawing.Point(153, 493);
            this.buttonClearFinSt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearFinSt.Name = "buttonClearFinSt";
            this.buttonClearFinSt.Size = new System.Drawing.Size(157, 28);
            this.buttonClearFinSt.TabIndex = 26;
            this.buttonClearFinSt.Text = "Очистить";
            this.buttonClearFinSt.UseVisualStyleBackColor = true;
            this.buttonClearFinSt.Click += new System.EventHandler(this.ButtonClearFinalStates_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.TableToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 28);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateTableToolStripMenuItem,
            this.ClearTableToolStripMenuItem});
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.TableToolStripMenuItem.Text = "Таблица";
            // 
            // UpdateTableToolStripMenuItem
            // 
            this.UpdateTableToolStripMenuItem.Name = "UpdateTableToolStripMenuItem";
            this.UpdateTableToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.UpdateTableToolStripMenuItem.Text = "Обновить";
            this.UpdateTableToolStripMenuItem.Click += new System.EventHandler(this.UpdateTableToolStripMenuItem_Click);
            // 
            // ClearTableToolStripMenuItem
            // 
            this.ClearTableToolStripMenuItem.Name = "ClearTableToolStripMenuItem";
            this.ClearTableToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.ClearTableToolStripMenuItem.Text = "Очистить";
            this.ClearTableToolStripMenuItem.Click += new System.EventHandler(this.ClearTableToolStripMenuItem_Click);
            // 
            // openFileDialogSaveLoad
            // 
            this.openFileDialogSaveLoad.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 526);
            this.Controls.Add(this.buttonClearFinSt);
            this.Controls.Add(this.buttonAddFinSt);
            this.Controls.Add(this.textBoxFinalStates);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStartState);
            this.Controls.Add(this.buttonAddCoFA);
            this.Controls.Add(this.textBoxNextState);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTrace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.dataGridViewRules);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Модель конечного автомата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTrace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.TextBox textBoxNextState;
        private System.Windows.Forms.Button buttonAddCoFA;
        private System.Windows.Forms.TextBox textBoxStartState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFinalStates;
        private System.Windows.Forms.Button buttonAddFinSt;
        private System.Windows.Forms.Button buttonClearFinSt;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearTableToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogSaveLoad;
    }
}

