namespace tamogochi
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
            this.components = new System.ComponentModel.Container();
            this.lblEatCur = new System.Windows.Forms.Label();
            this.lblEatMax = new System.Windows.Forms.Label();
            this.lblSleepCur = new System.Windows.Forms.Label();
            this.lblSleepMax = new System.Windows.Forms.Label();
            this.lblHappyCur = new System.Windows.Forms.Label();
            this.lblHappyMax = new System.Windows.Forms.Label();
            this.lblClearCur = new System.Windows.Forms.Label();
            this.lblClearMax = new System.Windows.Forms.Label();
            this.lblHPCur = new System.Windows.Forms.Label();
            this.lblHPMax = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.queue_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.pbQueue6 = new System.Windows.Forms.PictureBox();
            this.pbQueue5 = new System.Windows.Forms.PictureBox();
            this.pbQueue4 = new System.Windows.Forms.PictureBox();
            this.pbQueue3 = new System.Windows.Forms.PictureBox();
            this.pbQueue2 = new System.Windows.Forms.PictureBox();
            this.pbQueue1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.pbStack6 = new System.Windows.Forms.PictureBox();
            this.pbStack5 = new System.Windows.Forms.PictureBox();
            this.pbStack4 = new System.Windows.Forms.PictureBox();
            this.pbStack3 = new System.Windows.Forms.PictureBox();
            this.pbStack2 = new System.Windows.Forms.PictureBox();
            this.pbStack1 = new System.Windows.Forms.PictureBox();
            this.btnStackActions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Stack_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEatCur
            // 
            this.lblEatCur.AutoSize = true;
            this.lblEatCur.Location = new System.Drawing.Point(72, 76);
            this.lblEatCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEatCur.Name = "lblEatCur";
            this.lblEatCur.Size = new System.Drawing.Size(24, 17);
            this.lblEatCur.TabIndex = 0;
            this.lblEatCur.Text = "95";
            // 
            // lblEatMax
            // 
            this.lblEatMax.AutoSize = true;
            this.lblEatMax.Location = new System.Drawing.Point(53, 161);
            this.lblEatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEatMax.Name = "lblEatMax";
            this.lblEatMax.Size = new System.Drawing.Size(32, 17);
            this.lblEatMax.TabIndex = 1;
            this.lblEatMax.Text = "100";
            // 
            // lblSleepCur
            // 
            this.lblSleepCur.AutoSize = true;
            this.lblSleepCur.Location = new System.Drawing.Point(232, 76);
            this.lblSleepCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSleepCur.Name = "lblSleepCur";
            this.lblSleepCur.Size = new System.Drawing.Size(24, 17);
            this.lblSleepCur.TabIndex = 2;
            this.lblSleepCur.Text = "95";
            // 
            // lblSleepMax
            // 
            this.lblSleepMax.AutoSize = true;
            this.lblSleepMax.Location = new System.Drawing.Point(232, 161);
            this.lblSleepMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSleepMax.Name = "lblSleepMax";
            this.lblSleepMax.Size = new System.Drawing.Size(32, 17);
            this.lblSleepMax.TabIndex = 3;
            this.lblSleepMax.Text = "100";
            // 
            // lblHappyCur
            // 
            this.lblHappyCur.AutoSize = true;
            this.lblHappyCur.Location = new System.Drawing.Point(387, 76);
            this.lblHappyCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHappyCur.Name = "lblHappyCur";
            this.lblHappyCur.Size = new System.Drawing.Size(24, 17);
            this.lblHappyCur.TabIndex = 4;
            this.lblHappyCur.Text = "95";
            // 
            // lblHappyMax
            // 
            this.lblHappyMax.AutoSize = true;
            this.lblHappyMax.Location = new System.Drawing.Point(379, 161);
            this.lblHappyMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHappyMax.Name = "lblHappyMax";
            this.lblHappyMax.Size = new System.Drawing.Size(32, 17);
            this.lblHappyMax.TabIndex = 5;
            this.lblHappyMax.Text = "100";
            // 
            // lblClearCur
            // 
            this.lblClearCur.AutoSize = true;
            this.lblClearCur.Location = new System.Drawing.Point(536, 76);
            this.lblClearCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClearCur.Name = "lblClearCur";
            this.lblClearCur.Size = new System.Drawing.Size(24, 17);
            this.lblClearCur.TabIndex = 6;
            this.lblClearCur.Text = "95";
            // 
            // lblClearMax
            // 
            this.lblClearMax.AutoSize = true;
            this.lblClearMax.Location = new System.Drawing.Point(536, 161);
            this.lblClearMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClearMax.Name = "lblClearMax";
            this.lblClearMax.Size = new System.Drawing.Size(32, 17);
            this.lblClearMax.TabIndex = 7;
            this.lblClearMax.Text = "100";
            // 
            // lblHPCur
            // 
            this.lblHPCur.AutoSize = true;
            this.lblHPCur.Location = new System.Drawing.Point(781, 76);
            this.lblHPCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHPCur.Name = "lblHPCur";
            this.lblHPCur.Size = new System.Drawing.Size(24, 17);
            this.lblHPCur.TabIndex = 8;
            this.lblHPCur.Text = "95";
            // 
            // lblHPMax
            // 
            this.lblHPMax.AutoSize = true;
            this.lblHPMax.Location = new System.Drawing.Point(781, 162);
            this.lblHPMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHPMax.Name = "lblHPMax";
            this.lblHPMax.Size = new System.Drawing.Size(32, 17);
            this.lblHPMax.TabIndex = 9;
            this.lblHPMax.Text = "100";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(232, 498);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(63, 17);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "Он умер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "очередь";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(904, 444);
            this.btnAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 23;
            this.btnAction.Text = "Сделай!!";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pbQueue6
            // 
            this.pbQueue6.Location = new System.Drawing.Point(899, 377);
            this.pbQueue6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue6.Name = "pbQueue6";
            this.pbQueue6.Size = new System.Drawing.Size(100, 50);
            this.pbQueue6.TabIndex = 29;
            this.pbQueue6.TabStop = false;
            // 
            // pbQueue5
            // 
            this.pbQueue5.Location = new System.Drawing.Point(899, 321);
            this.pbQueue5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue5.Name = "pbQueue5";
            this.pbQueue5.Size = new System.Drawing.Size(100, 50);
            this.pbQueue5.TabIndex = 28;
            this.pbQueue5.TabStop = false;
            // 
            // pbQueue4
            // 
            this.pbQueue4.Location = new System.Drawing.Point(899, 265);
            this.pbQueue4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue4.Name = "pbQueue4";
            this.pbQueue4.Size = new System.Drawing.Size(100, 50);
            this.pbQueue4.TabIndex = 27;
            this.pbQueue4.TabStop = false;
            // 
            // pbQueue3
            // 
            this.pbQueue3.Location = new System.Drawing.Point(899, 209);
            this.pbQueue3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue3.Name = "pbQueue3";
            this.pbQueue3.Size = new System.Drawing.Size(100, 50);
            this.pbQueue3.TabIndex = 26;
            this.pbQueue3.TabStop = false;
            // 
            // pbQueue2
            // 
            this.pbQueue2.Location = new System.Drawing.Point(899, 164);
            this.pbQueue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue2.Name = "pbQueue2";
            this.pbQueue2.Size = new System.Drawing.Size(100, 50);
            this.pbQueue2.TabIndex = 25;
            this.pbQueue2.TabStop = false;
            // 
            // pbQueue1
            // 
            this.pbQueue1.Location = new System.Drawing.Point(899, 115);
            this.pbQueue1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQueue1.Name = "pbQueue1";
            this.pbQueue1.Size = new System.Drawing.Size(100, 50);
            this.pbQueue1.TabIndex = 24;
            this.pbQueue1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::tamogochi.Properties.Resources.icon_food;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(21, 95);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(139, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::tamogochi.Properties.Resources.icon_sleep;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(181, 96);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::tamogochi.Properties.Resources.icon_happy;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(336, 96);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::tamogochi.Properties.Resources.icon_clear;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(480, 96);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tamogochi.Properties.Resources.icon_health;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(733, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::tamogochi.Properties.Resources.main;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(95, 188);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(380, 284);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackgroundImage = global::tamogochi.Properties.Resources.btn_bg_clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(733, 361);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 112);
            this.btnClear.TabIndex = 14;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackgroundImage = global::tamogochi.Properties.Resources.btn_bg_sleep;
            this.btnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSleep.FlatAppearance.BorderSize = 0;
            this.btnSleep.Location = new System.Drawing.Point(733, 240);
            this.btnSleep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(121, 101);
            this.btnSleep.TabIndex = 13;
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnHappy
            // 
            this.btnHappy.BackgroundImage = global::tamogochi.Properties.Resources.btn_bg_play;
            this.btnHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHappy.FlatAppearance.BorderSize = 0;
            this.btnHappy.Location = new System.Drawing.Point(567, 361);
            this.btnHappy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(113, 112);
            this.btnHappy.TabIndex = 12;
            this.btnHappy.UseVisualStyleBackColor = true;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // btnEat
            // 
            this.btnEat.BackgroundImage = global::tamogochi.Properties.Resources.btn_bg_food;
            this.btnEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEat.FlatAppearance.BorderSize = 0;
            this.btnEat.Location = new System.Drawing.Point(567, 240);
            this.btnEat.Margin = new System.Windows.Forms.Padding(4);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(113, 101);
            this.btnEat.TabIndex = 11;
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // pbStack6
            // 
            this.pbStack6.Location = new System.Drawing.Point(1062, 376);
            this.pbStack6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack6.Name = "pbStack6";
            this.pbStack6.Size = new System.Drawing.Size(100, 50);
            this.pbStack6.TabIndex = 37;
            this.pbStack6.TabStop = false;
            // 
            // pbStack5
            // 
            this.pbStack5.Location = new System.Drawing.Point(1062, 320);
            this.pbStack5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack5.Name = "pbStack5";
            this.pbStack5.Size = new System.Drawing.Size(100, 50);
            this.pbStack5.TabIndex = 36;
            this.pbStack5.TabStop = false;
            // 
            // pbStack4
            // 
            this.pbStack4.Location = new System.Drawing.Point(1062, 264);
            this.pbStack4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack4.Name = "pbStack4";
            this.pbStack4.Size = new System.Drawing.Size(100, 50);
            this.pbStack4.TabIndex = 35;
            this.pbStack4.TabStop = false;
            // 
            // pbStack3
            // 
            this.pbStack3.Location = new System.Drawing.Point(1062, 208);
            this.pbStack3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack3.Name = "pbStack3";
            this.pbStack3.Size = new System.Drawing.Size(100, 50);
            this.pbStack3.TabIndex = 34;
            this.pbStack3.TabStop = false;
            // 
            // pbStack2
            // 
            this.pbStack2.Location = new System.Drawing.Point(1062, 163);
            this.pbStack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack2.Name = "pbStack2";
            this.pbStack2.Size = new System.Drawing.Size(100, 50);
            this.pbStack2.TabIndex = 33;
            this.pbStack2.TabStop = false;
            // 
            // pbStack1
            // 
            this.pbStack1.Location = new System.Drawing.Point(1062, 115);
            this.pbStack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStack1.Name = "pbStack1";
            this.pbStack1.Size = new System.Drawing.Size(100, 50);
            this.pbStack1.TabIndex = 32;
            this.pbStack1.TabStop = false;
            // 
            // btnStackActions
            // 
            this.btnStackActions.Location = new System.Drawing.Point(1067, 443);
            this.btnStackActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStackActions.Name = "btnStackActions";
            this.btnStackActions.Size = new System.Drawing.Size(75, 23);
            this.btnStackActions.TabIndex = 31;
            this.btnStackActions.Text = "Сделай!!";
            this.btnStackActions.UseVisualStyleBackColor = true;
            this.btnStackActions.Click += new System.EventHandler(this.btnStackActions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1105, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "стек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 654);
            this.Controls.Add(this.pbStack6);
            this.Controls.Add(this.pbStack5);
            this.Controls.Add(this.pbStack4);
            this.Controls.Add(this.pbStack3);
            this.Controls.Add(this.pbStack2);
            this.Controls.Add(this.pbStack1);
            this.Controls.Add(this.btnStackActions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbQueue6);
            this.Controls.Add(this.pbQueue5);
            this.Controls.Add(this.pbQueue4);
            this.Controls.Add(this.pbQueue3);
            this.Controls.Add(this.pbQueue2);
            this.Controls.Add(this.pbQueue1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.lblHPMax);
            this.Controls.Add(this.lblHPCur);
            this.Controls.Add(this.lblClearMax);
            this.Controls.Add(this.lblClearCur);
            this.Controls.Add(this.lblHappyMax);
            this.Controls.Add(this.lblHappyCur);
            this.Controls.Add(this.lblSleepMax);
            this.Controls.Add(this.lblSleepCur);
            this.Controls.Add(this.lblEatMax);
            this.Controls.Add(this.lblEatCur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEatCur;
        private System.Windows.Forms.Label lblEatMax;
        private System.Windows.Forms.Label lblSleepCur;
        private System.Windows.Forms.Label lblSleepMax;
        private System.Windows.Forms.Label lblHappyCur;
        private System.Windows.Forms.Label lblHappyMax;
        private System.Windows.Forms.Label lblClearCur;
        private System.Windows.Forms.Label lblClearMax;
        private System.Windows.Forms.Label lblHPCur;
        private System.Windows.Forms.Label lblHPMax;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Timer queue_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox pbQueue1;
        private System.Windows.Forms.PictureBox pbQueue2;
        private System.Windows.Forms.PictureBox pbQueue3;
        private System.Windows.Forms.PictureBox pbQueue4;
        private System.Windows.Forms.PictureBox pbQueue5;
        private System.Windows.Forms.PictureBox pbQueue6;
        private System.Windows.Forms.PictureBox pbStack6;
        private System.Windows.Forms.PictureBox pbStack5;
        private System.Windows.Forms.PictureBox pbStack4;
        private System.Windows.Forms.PictureBox pbStack3;
        private System.Windows.Forms.PictureBox pbStack2;
        private System.Windows.Forms.PictureBox pbStack1;
        private System.Windows.Forms.Button btnStackActions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Stack_timer;
    }
}

