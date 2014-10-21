﻿namespace NapoleonCode.Win
{
    partial class DbSqLite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbSqLite));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TreeDataBase = new System.Windows.Forms.TreeView();
            this.CobSelectTemb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PlAutofacTemp = new System.Windows.Forms.Panel();
            this.RadAutofacXml = new System.Windows.Forms.RadioButton();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).BeginInit();
            this.PlAutofacTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TreeDataBase);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(319, 774);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "数据库表(双击加载)";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnReturn);
            this.groupControl2.Controls.Add(this.BtnSubmit);
            this.groupControl2.Controls.Add(this.PlAutofacTemp);
            this.groupControl2.Controls.Add(this.CobSelectTemb);
            this.groupControl2.Location = new System.Drawing.Point(337, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(935, 773);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "生成代码";
            // 
            // TreeDataBase
            // 
            this.TreeDataBase.AllowDrop = true;
            this.TreeDataBase.Location = new System.Drawing.Point(5, 25);
            this.TreeDataBase.Name = "TreeDataBase";
            this.TreeDataBase.Size = new System.Drawing.Size(308, 744);
            this.TreeDataBase.TabIndex = 1;
            // 
            // CobSelectTemb
            // 
            this.CobSelectTemb.Location = new System.Drawing.Point(5, 34);
            this.CobSelectTemb.Name = "CobSelectTemb";
            this.CobSelectTemb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobSelectTemb.Properties.Items.AddRange(new object[] {
            "基本模版",
            "NHibernate模版",
            "AutoFac模版"});
            this.CobSelectTemb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobSelectTemb.Size = new System.Drawing.Size(181, 20);
            this.CobSelectTemb.TabIndex = 8;
            // 
            // PlAutofacTemp
            // 
            this.PlAutofacTemp.Controls.Add(this.RadAutofacXml);
            this.PlAutofacTemp.Location = new System.Drawing.Point(192, 29);
            this.PlAutofacTemp.Name = "PlAutofacTemp";
            this.PlAutofacTemp.Size = new System.Drawing.Size(596, 29);
            this.PlAutofacTemp.TabIndex = 9;
            // 
            // RadAutofacXml
            // 
            this.RadAutofacXml.AutoSize = true;
            this.RadAutofacXml.Location = new System.Drawing.Point(19, 5);
            this.RadAutofacXml.Name = "RadAutofacXml";
            this.RadAutofacXml.Size = new System.Drawing.Size(73, 18);
            this.RadAutofacXml.TabIndex = 0;
            this.RadAutofacXml.TabStop = true;
            this.RadAutofacXml.Text = "配置文件";
            this.RadAutofacXml.UseVisualStyleBackColor = true;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(861, 31);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(59, 23);
            this.BtnReturn.TabIndex = 11;
            this.BtnReturn.Text = "返回";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(794, 31);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(59, 23);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "生成";
            // 
            // DbSqLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 798);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DbSqLite";
            this.Text = "动态模版";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).EndInit();
            this.PlAutofacTemp.ResumeLayout(false);
            this.PlAutofacTemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TreeView TreeDataBase;
        private DevExpress.XtraEditors.ComboBoxEdit CobSelectTemb;
        private System.Windows.Forms.Panel PlAutofacTemp;
        private System.Windows.Forms.RadioButton RadAutofacXml;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
    }
}