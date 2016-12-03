﻿namespace LiquidViscosity
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contolPanelGroup = new System.Windows.Forms.GroupBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeFactorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeFactorSlider = new System.Windows.Forms.TrackBar();
            this.Graph = new System.Windows.Forms.Button();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.matName = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BallMaterial = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.BallRadius = new System.Windows.Forms.TrackBar();
            this.liqudChoice = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OGLVP = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contolPanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFactorSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallRadius)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contolPanelGroup
            // 
            this.contolPanelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contolPanelGroup.Controls.Add(this.TimerLabel);
            this.contolPanelGroup.Controls.Add(this.label3);
            this.contolPanelGroup.Controls.Add(this.TimeFactorLabel);
            this.contolPanelGroup.Controls.Add(this.label7);
            this.contolPanelGroup.Controls.Add(this.TimeFactorSlider);
            this.contolPanelGroup.Controls.Add(this.Graph);
            this.contolPanelGroup.Controls.Add(this.radiusLabel);
            this.contolPanelGroup.Controls.Add(this.matName);
            this.contolPanelGroup.Controls.Add(this.stop);
            this.contolPanelGroup.Controls.Add(this.start);
            this.contolPanelGroup.Controls.Add(this.label2);
            this.contolPanelGroup.Controls.Add(this.BallMaterial);
            this.contolPanelGroup.Controls.Add(this.label1);
            this.contolPanelGroup.Controls.Add(this.BallRadius);
            this.contolPanelGroup.Controls.Add(this.liqudChoice);
            this.contolPanelGroup.Location = new System.Drawing.Point(774, 27);
            this.contolPanelGroup.Name = "contolPanelGroup";
            this.contolPanelGroup.Size = new System.Drawing.Size(229, 311);
            this.contolPanelGroup.TabIndex = 0;
            this.contolPanelGroup.TabStop = false;
            this.contolPanelGroup.Text = "Управление экспериментом";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(68, 247);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(63, 19);
            this.TimerLabel.TabIndex = 14;
            this.TimerLabel.Text = "0.00 с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Таймер:";
            // 
            // TimeFactorLabel
            // 
            this.TimeFactorLabel.AutoSize = true;
            this.TimeFactorLabel.Location = new System.Drawing.Point(157, 211);
            this.TimeFactorLabel.Name = "TimeFactorLabel";
            this.TimeFactorLabel.Size = new System.Drawing.Size(38, 13);
            this.TimeFactorLabel.TabIndex = 12;
            this.TimeFactorLabel.Text = "X 1.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Скорость эксперимента";
            // 
            // TimeFactorSlider
            // 
            this.TimeFactorSlider.LargeChange = 1;
            this.TimeFactorSlider.Location = new System.Drawing.Point(13, 202);
            this.TimeFactorSlider.Maximum = 3;
            this.TimeFactorSlider.Name = "TimeFactorSlider";
            this.TimeFactorSlider.Size = new System.Drawing.Size(147, 45);
            this.TimeFactorSlider.TabIndex = 10;
            this.TimeFactorSlider.Scroll += new System.EventHandler(this.TimeFactorSlider_Scroll);
            // 
            // Graph
            // 
            this.Graph.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Graph.Location = new System.Drawing.Point(152, 282);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(71, 23);
            this.Graph.TabIndex = 9;
            this.Graph.Text = "График";
            this.Graph.UseVisualStyleBackColor = true;
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(160, 85);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(40, 13);
            this.radiusLabel.TabIndex = 8;
            this.radiusLabel.Text = "Radius";
            // 
            // matName
            // 
            this.matName.AutoSize = true;
            this.matName.Location = new System.Drawing.Point(159, 147);
            this.matName.Name = "matName";
            this.matName.Size = new System.Drawing.Size(44, 13);
            this.matName.TabIndex = 7;
            this.matName.Text = "Свинец";
            // 
            // stop
            // 
            this.stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(79, 282);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(71, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "СТОП";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start.Location = new System.Drawing.Point(6, 282);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(71, 23);
            this.start.TabIndex = 5;
            this.start.Text = "ПУСК";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Материал шарика";
            // 
            // BallMaterial
            // 
            this.BallMaterial.LargeChange = 1;
            this.BallMaterial.Location = new System.Drawing.Point(13, 138);
            this.BallMaterial.Maximum = 2;
            this.BallMaterial.Name = "BallMaterial";
            this.BallMaterial.Size = new System.Drawing.Size(147, 45);
            this.BallMaterial.TabIndex = 3;
            this.BallMaterial.Scroll += new System.EventHandler(this.BallMaterial_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус шарика";
            // 
            // BallRadius
            // 
            this.BallRadius.Location = new System.Drawing.Point(13, 77);
            this.BallRadius.Maximum = 30;
            this.BallRadius.Name = "BallRadius";
            this.BallRadius.Size = new System.Drawing.Size(147, 45);
            this.BallRadius.TabIndex = 1;
            this.BallRadius.TickFrequency = 5;
            this.BallRadius.Scroll += new System.EventHandler(this.BallRadius_Scroll);
            // 
            // liqudChoice
            // 
            this.liqudChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liqudChoice.FormattingEnabled = true;
            this.liqudChoice.Items.AddRange(new object[] {
            "Вода",
            "Глицерин",
            "Растительное масло"});
            this.liqudChoice.Location = new System.Drawing.Point(7, 20);
            this.liqudChoice.Name = "liqudChoice";
            this.liqudChoice.Size = new System.Drawing.Size(216, 21);
            this.liqudChoice.TabIndex = 0;
            this.liqudChoice.SelectedIndexChanged += new System.EventHandler(this.liqudChoice_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.FileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.FileToolStripMenuItem.Text = "Выход";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpHelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ExpHelpToolStripMenuItem
            // 
            this.ExpHelpToolStripMenuItem.Name = "ExpHelpToolStripMenuItem";
            this.ExpHelpToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ExpHelpToolStripMenuItem.Text = "Справка по эксперименту";
            this.ExpHelpToolStripMenuItem.Click += new System.EventHandler(this.ExpHelpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OGLVP
            // 
            this.OGLVP.AccumBits = ((byte)(0));
            this.OGLVP.AutoCheckErrors = false;
            this.OGLVP.AutoFinish = false;
            this.OGLVP.AutoMakeCurrent = true;
            this.OGLVP.AutoSwapBuffers = true;
            this.OGLVP.BackColor = System.Drawing.Color.Black;
            this.OGLVP.ColorBits = ((byte)(32));
            this.OGLVP.DepthBits = ((byte)(16));
            this.OGLVP.Location = new System.Drawing.Point(0, 27);
            this.OGLVP.Name = "OGLVP";
            this.OGLVP.Size = new System.Drawing.Size(761, 657);
            this.OGLVP.StencilBits = ((byte)(0));
            this.OGLVP.TabIndex = 3;
            this.OGLVP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OGLVP_MouseDown);
            this.OGLVP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OGLVP_MouseMove);
            this.OGLVP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OGLVP_MouseUp);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 16;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.emailLink);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(774, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 343);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(119, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "ПМ-53\r\nПМ-53\r\nПМ-53";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(94, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "2016";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(56, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Новосибирск";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiquidViscosity.Properties.Resources.NSTU_Logo_blue;
            this.pictureBox1.Location = new System.Drawing.Point(7, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // emailLink
            // 
            this.emailLink.AutoSize = true;
            this.emailLink.Location = new System.Drawing.Point(119, 96);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(98, 13);
            this.emailLink.TabIndex = 7;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "baranovav@ngs.ru";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Баранов А. В.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Руководитель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 51);
            this.label5.TabIndex = 2;
            this.label5.Text = "Гончаренко Д. И.\r\nМалахов И. С.\r\nТябин Е. А.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Разработчики:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OGLVP);
            this.Controls.Add(this.contolPanelGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виртуальный эксперимент \"Определение вязкости жидкости методом Стокса\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contolPanelGroup.ResumeLayout(false);
            this.contolPanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFactorSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallRadius)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox contolPanelGroup;
        private System.Windows.Forms.ComboBox liqudChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar BallMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BallRadius;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label matName;
        private System.Windows.Forms.Label radiusLabel;
        private Tao.Platform.Windows.SimpleOpenGlControl OGLVP;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Graph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TimeFactorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TimeFactorSlider;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label label3;
    }
}

