namespace Techno.UI
{
    partial class OrderView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbClient = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.grpOper = new System.Windows.Forms.GroupBox();
            this.grpMaster = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDefect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTypeEq = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaster = new System.Windows.Forms.ComboBox();
            this.txtZapchasty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnViewCom = new System.Windows.Forms.Button();
            this.grbClient.SuspendLayout();
            this.grpOper.SuspendLayout();
            this.grpMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbClient
            // 
            this.grbClient.Controls.Add(this.cmbTypeEq);
            this.grbClient.Controls.Add(this.label4);
            this.grbClient.Controls.Add(this.txtDefect);
            this.grbClient.Controls.Add(this.label3);
            this.grbClient.Controls.Add(this.txtModel);
            this.grbClient.Controls.Add(this.label2);
            this.grbClient.Location = new System.Drawing.Point(3, 81);
            this.grbClient.Name = "grbClient";
            this.grbClient.Size = new System.Drawing.Size(195, 189);
            this.grbClient.TabIndex = 0;
            this.grbClient.TabStop = false;
            this.grbClient.Text = "Данные клиента";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 16);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Заказ номер: ";
            // 
            // grpOper
            // 
            this.grpOper.Controls.Add(this.cmbMaster);
            this.grpOper.Controls.Add(this.label6);
            this.grpOper.Controls.Add(this.cmbStatus);
            this.grpOper.Controls.Add(this.label5);
            this.grpOper.Location = new System.Drawing.Point(204, 81);
            this.grpOper.Name = "grpOper";
            this.grpOper.Size = new System.Drawing.Size(226, 189);
            this.grpOper.TabIndex = 2;
            this.grpOper.TabStop = false;
            this.grpOper.Text = "Данные оператора";
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.btnAddComment);
            this.grpMaster.Controls.Add(this.txtZapchasty);
            this.grpMaster.Controls.Add(this.label7);
            this.grpMaster.Location = new System.Drawing.Point(3, 276);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(269, 94);
            this.grpMaster.TabIndex = 3;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Данные мастера";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Создание заказа:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(116, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Дата";
            // 
            // lblNomer
            // 
            this.lblNomer.AutoSize = true;
            this.lblNomer.Location = new System.Drawing.Point(107, 16);
            this.lblNomer.Name = "lblNomer";
            this.lblNomer.Size = new System.Drawing.Size(80, 13);
            this.lblNomer.TabIndex = 7;
            this.lblNomer.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Модель оборудования";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(6, 43);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(178, 20);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Модель";
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtDefect
            // 
            this.txtDefect.Location = new System.Drawing.Point(6, 122);
            this.txtDefect.Multiline = true;
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(178, 48);
            this.txtDefect.TabIndex = 3;
            this.txtDefect.Text = "Модель";
            this.txtDefect.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание поломки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вид оборудования";
            // 
            // cmbTypeEq
            // 
            this.cmbTypeEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeEq.FormattingEnabled = true;
            this.cmbTypeEq.Location = new System.Drawing.Point(6, 82);
            this.cmbTypeEq.Name = "cmbTypeEq";
            this.cmbTypeEq.Size = new System.Drawing.Size(178, 21);
            this.cmbTypeEq.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Статус заявки";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(9, 43);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(103, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Мастер";
            // 
            // cmbMaster
            // 
            this.cmbMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaster.FormattingEnabled = true;
            this.cmbMaster.Location = new System.Drawing.Point(9, 83);
            this.cmbMaster.Name = "cmbMaster";
            this.cmbMaster.Size = new System.Drawing.Size(211, 21);
            this.cmbMaster.TabIndex = 8;
            // 
            // txtZapchasty
            // 
            this.txtZapchasty.Location = new System.Drawing.Point(6, 40);
            this.txtZapchasty.Multiline = true;
            this.txtZapchasty.Name = "txtZapchasty";
            this.txtZapchasty.Size = new System.Drawing.Size(257, 48);
            this.txtZapchasty.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Запчасти";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ФИО";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(224, 48);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 9;
            this.lblFio.Text = "ФИО";
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(116, 11);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(147, 23);
            this.btnAddComment.TabIndex = 10;
            this.btnAddComment.Text = "Добавить комментарий";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnViewCom
            // 
            this.btnViewCom.Location = new System.Drawing.Point(305, 325);
            this.btnViewCom.Name = "btnViewCom";
            this.btnViewCom.Size = new System.Drawing.Size(100, 39);
            this.btnViewCom.TabIndex = 10;
            this.btnViewCom.Text = "Просмотр комментариев";
            this.btnViewCom.UseVisualStyleBackColor = true;
            this.btnViewCom.Click += new System.EventHandler(this.btnViewCom_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewCom);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNomer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.grpOper);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.grbClient);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(433, 373);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.grbClient.ResumeLayout(false);
            this.grbClient.PerformLayout();
            this.grpOper.ResumeLayout(false);
            this.grpOper.PerformLayout();
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox grpOper;
        private System.Windows.Forms.GroupBox grpMaster;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNomer;
        private System.Windows.Forms.ComboBox cmbTypeEq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbMaster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZapchasty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnViewCom;
    }
}
