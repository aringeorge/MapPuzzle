namespace MapPuzzle
{
   partial class frmMainForm
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
         this.components = new System.ComponentModel.Container();
         this.pnlGameBoard = new System.Windows.Forms.Panel();
         this.cmdNewGame = new System.Windows.Forms.Button();
         this.pnlGameStatistics = new System.Windows.Forms.Panel();
         this.lblMapUncoveredValue = new System.Windows.Forms.Label();
         this.lblMapUncoveredStatic = new System.Windows.Forms.Label();
         this.lblMovesLeftValue = new System.Windows.Forms.Label();
         this.lblMovesLeftStatic = new System.Windows.Forms.Label();
         this.lblMoveCountValue = new System.Windows.Forms.Label();
         this.lblMoveCountStatic = new System.Windows.Forms.Label();
         this.lblGameTimeValue = new System.Windows.Forms.Label();
         this.lblGameTimeStatic = new System.Windows.Forms.Label();
         this.tmrRenderingThread = new System.Windows.Forms.Timer(this.components);
         this.tmrTextUpdateThread = new System.Windows.Forms.Timer(this.components);
         this.tmrGameStateThread = new System.Windows.Forms.Timer(this.components);
         this.pnlGameStatistics.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlGameBoard
         // 
         this.pnlGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pnlGameBoard.Location = new System.Drawing.Point(296, 18);
         this.pnlGameBoard.Name = "pnlGameBoard";
         this.pnlGameBoard.Size = new System.Drawing.Size(700, 700);
         this.pnlGameBoard.TabIndex = 1;
         // 
         // cmdNewGame
         // 
         this.cmdNewGame.Location = new System.Drawing.Point(20, 18);
         this.cmdNewGame.Name = "cmdNewGame";
         this.cmdNewGame.Size = new System.Drawing.Size(103, 52);
         this.cmdNewGame.TabIndex = 2;
         this.cmdNewGame.Text = "New Game";
         this.cmdNewGame.UseVisualStyleBackColor = true;
         this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
         // 
         // pnlGameStatistics
         // 
         this.pnlGameStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pnlGameStatistics.Controls.Add(this.lblMapUncoveredValue);
         this.pnlGameStatistics.Controls.Add(this.lblMapUncoveredStatic);
         this.pnlGameStatistics.Controls.Add(this.lblMovesLeftValue);
         this.pnlGameStatistics.Controls.Add(this.lblMovesLeftStatic);
         this.pnlGameStatistics.Controls.Add(this.lblMoveCountValue);
         this.pnlGameStatistics.Controls.Add(this.lblMoveCountStatic);
         this.pnlGameStatistics.Controls.Add(this.lblGameTimeValue);
         this.pnlGameStatistics.Controls.Add(this.lblGameTimeStatic);
         this.pnlGameStatistics.Location = new System.Drawing.Point(12, 195);
         this.pnlGameStatistics.Name = "pnlGameStatistics";
         this.pnlGameStatistics.Size = new System.Drawing.Size(272, 523);
         this.pnlGameStatistics.TabIndex = 3;
         // 
         // lblMapUncoveredValue
         // 
         this.lblMapUncoveredValue.AutoSize = true;
         this.lblMapUncoveredValue.Location = new System.Drawing.Point(101, 85);
         this.lblMapUncoveredValue.Name = "lblMapUncoveredValue";
         this.lblMapUncoveredValue.Size = new System.Drawing.Size(0, 13);
         this.lblMapUncoveredValue.TabIndex = 7;
         // 
         // lblMapUncoveredStatic
         // 
         this.lblMapUncoveredStatic.AutoSize = true;
         this.lblMapUncoveredStatic.Location = new System.Drawing.Point(3, 85);
         this.lblMapUncoveredStatic.Name = "lblMapUncoveredStatic";
         this.lblMapUncoveredStatic.Size = new System.Drawing.Size(88, 13);
         this.lblMapUncoveredStatic.TabIndex = 6;
         this.lblMapUncoveredStatic.Text = "Tiles Uncovered:";
         // 
         // lblMovesLeftValue
         // 
         this.lblMovesLeftValue.AutoSize = true;
         this.lblMovesLeftValue.Location = new System.Drawing.Point(101, 60);
         this.lblMovesLeftValue.Name = "lblMovesLeftValue";
         this.lblMovesLeftValue.Size = new System.Drawing.Size(0, 13);
         this.lblMovesLeftValue.TabIndex = 5;
         // 
         // lblMovesLeftStatic
         // 
         this.lblMovesLeftStatic.AutoSize = true;
         this.lblMovesLeftStatic.Location = new System.Drawing.Point(3, 60);
         this.lblMovesLeftStatic.Name = "lblMovesLeftStatic";
         this.lblMovesLeftStatic.Size = new System.Drawing.Size(63, 13);
         this.lblMovesLeftStatic.TabIndex = 4;
         this.lblMovesLeftStatic.Text = "Moves Left:";
         // 
         // lblMoveCountValue
         // 
         this.lblMoveCountValue.AutoSize = true;
         this.lblMoveCountValue.Location = new System.Drawing.Point(101, 35);
         this.lblMoveCountValue.Name = "lblMoveCountValue";
         this.lblMoveCountValue.Size = new System.Drawing.Size(0, 13);
         this.lblMoveCountValue.TabIndex = 3;
         // 
         // lblMoveCountStatic
         // 
         this.lblMoveCountStatic.AutoSize = true;
         this.lblMoveCountStatic.Location = new System.Drawing.Point(3, 35);
         this.lblMoveCountStatic.Name = "lblMoveCountStatic";
         this.lblMoveCountStatic.Size = new System.Drawing.Size(76, 13);
         this.lblMoveCountStatic.TabIndex = 2;
         this.lblMoveCountStatic.Text = "Moves Taken:";
         // 
         // lblGameTimeValue
         // 
         this.lblGameTimeValue.AutoSize = true;
         this.lblGameTimeValue.Location = new System.Drawing.Point(101, 10);
         this.lblGameTimeValue.Name = "lblGameTimeValue";
         this.lblGameTimeValue.Size = new System.Drawing.Size(0, 13);
         this.lblGameTimeValue.TabIndex = 1;
         // 
         // lblGameTimeStatic
         // 
         this.lblGameTimeStatic.AutoSize = true;
         this.lblGameTimeStatic.Location = new System.Drawing.Point(3, 10);
         this.lblGameTimeStatic.Name = "lblGameTimeStatic";
         this.lblGameTimeStatic.Size = new System.Drawing.Size(67, 13);
         this.lblGameTimeStatic.TabIndex = 0;
         this.lblGameTimeStatic.Text = "Time Taken:";
         // 
         // tmrRenderingThread
         // 
         this.tmrRenderingThread.Interval = 10;
         this.tmrRenderingThread.Tick += new System.EventHandler(this.tmrRenderingThread_Tick);
         // 
         // tmrTextUpdateThread
         // 
         this.tmrTextUpdateThread.Interval = 193;
         this.tmrTextUpdateThread.Tick += new System.EventHandler(this.tmrTextUpdateThread_Tick);
         // 
         // tmrGameStateThread
         // 
         this.tmrGameStateThread.Interval = 1;
         this.tmrGameStateThread.Tick += new System.EventHandler(this.tmrGameStateThread_Tick);
         // 
         // frmMainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 730);
         this.Controls.Add(this.pnlGameStatistics);
         this.Controls.Add(this.cmdNewGame);
         this.Controls.Add(this.pnlGameBoard);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(1024, 768);
         this.MinimumSize = new System.Drawing.Size(1024, 768);
         this.Name = "frmMainForm";
         this.Text = "Map Puzzle";
         this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMainForm_KeyUp);
         this.pnlGameStatistics.ResumeLayout(false);
         this.pnlGameStatistics.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlGameBoard;
      private System.Windows.Forms.Button cmdNewGame;
      private System.Windows.Forms.Panel pnlGameStatistics;
      private System.Windows.Forms.Label lblGameTimeValue;
      private System.Windows.Forms.Label lblGameTimeStatic;
      private System.Windows.Forms.Label lblMoveCountValue;
      private System.Windows.Forms.Label lblMoveCountStatic;
      private System.Windows.Forms.Label lblMovesLeftValue;
      private System.Windows.Forms.Label lblMovesLeftStatic;
      private System.Windows.Forms.Label lblMapUncoveredValue;
      private System.Windows.Forms.Label lblMapUncoveredStatic;
      private System.Windows.Forms.Timer tmrRenderingThread;
      private System.Windows.Forms.Timer tmrTextUpdateThread;
      private System.Windows.Forms.Timer tmrGameStateThread;
   }
}

