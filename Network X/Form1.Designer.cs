namespace Network_X
{
    partial class networkX
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIP = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblDns = new System.Windows.Forms.Label();
            this.sysGateway = new System.Windows.Forms.Label();
            this.sysDNSServers = new System.Windows.Forms.Label();
            this.sysIP = new System.Windows.Forms.Label();
            this.checkNIC = new System.Windows.Forms.Button();
            this.netXResult = new System.Windows.Forms.Label();
            this.networkStatus = new System.Windows.Forms.Button();
            this.flushDNS = new System.Windows.Forms.Button();
            this.releaseRenewIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(94, 49);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(57, 20);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "Your IP:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(94, 83);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(102, 20);
            this.lblGateway.TabIndex = 1;
            this.lblGateway.Text = "Your Gateway:";
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.Location = new System.Drawing.Point(94, 119);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(75, 20);
            this.lblDns.TabIndex = 2;
            this.lblDns.Text = "Your DNS:";
            // 
            // sysGateway
            // 
            this.sysGateway.AutoSize = true;
            this.sysGateway.Location = new System.Drawing.Point(242, 83);
            this.sysGateway.Name = "sysGateway";
            this.sysGateway.Size = new System.Drawing.Size(66, 20);
            this.sysGateway.TabIndex = 3;
            this.sysGateway.Text = "Gateway";
            // 
            // sysDNSServers
            // 
            this.sysDNSServers.AutoSize = true;
            this.sysDNSServers.Location = new System.Drawing.Point(242, 119);
            this.sysDNSServers.Name = "sysDNSServers";
            this.sysDNSServers.Size = new System.Drawing.Size(39, 20);
            this.sysDNSServers.TabIndex = 4;
            this.sysDNSServers.Text = "DNS";
            // 
            // sysIP
            // 
            this.sysIP.AutoSize = true;
            this.sysIP.Location = new System.Drawing.Point(242, 49);
            this.sysIP.Name = "sysIP";
            this.sysIP.Size = new System.Drawing.Size(21, 20);
            this.sysIP.TabIndex = 5;
            this.sysIP.Text = "IP";
            // 
            // checkNIC
            // 
            this.checkNIC.Location = new System.Drawing.Point(69, 225);
            this.checkNIC.Name = "checkNIC";
            this.checkNIC.Size = new System.Drawing.Size(194, 55);
            this.checkNIC.TabIndex = 6;
            this.checkNIC.Text = "Check NIC";
            this.checkNIC.UseVisualStyleBackColor = true;
            this.checkNIC.Click += new System.EventHandler(this.checkNIC_Click);
            // 
            // netXResult
            // 
            this.netXResult.AutoSize = true;
            this.netXResult.Location = new System.Drawing.Point(94, 174);
            this.netXResult.Name = "netXResult";
            this.netXResult.Size = new System.Drawing.Size(49, 20);
            this.netXResult.TabIndex = 7;
            this.netXResult.Text = "Status";
            // 
            // networkStatus
            // 
            this.networkStatus.Location = new System.Drawing.Point(305, 225);
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(194, 55);
            this.networkStatus.TabIndex = 8;
            this.networkStatus.Text = "Network Status";
            this.networkStatus.UseVisualStyleBackColor = true;
            this.networkStatus.Click += new System.EventHandler(this.networkStatus_Click);
            // 
            // flushDNS
            // 
            this.flushDNS.Location = new System.Drawing.Point(545, 225);
            this.flushDNS.Name = "flushDNS";
            this.flushDNS.Size = new System.Drawing.Size(194, 55);
            this.flushDNS.TabIndex = 9;
            this.flushDNS.Text = "Flush DNS";
            this.flushDNS.UseVisualStyleBackColor = true;
            this.flushDNS.Click += new System.EventHandler(this.flushDNS_Click);
            // 
            // releaseRenewIP
            // 
            this.releaseRenewIP.Location = new System.Drawing.Point(69, 313);
            this.releaseRenewIP.Name = "releaseRenewIP";
            this.releaseRenewIP.Size = new System.Drawing.Size(194, 55);
            this.releaseRenewIP.TabIndex = 10;
            this.releaseRenewIP.Text = "Release/Renew IP";
            this.releaseRenewIP.UseVisualStyleBackColor = true;
            this.releaseRenewIP.Click += new System.EventHandler(this.releaseRenewIP_Click);
            // 
            // networkX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.releaseRenewIP);
            this.Controls.Add(this.flushDNS);
            this.Controls.Add(this.networkStatus);
            this.Controls.Add(this.netXResult);
            this.Controls.Add(this.checkNIC);
            this.Controls.Add(this.sysIP);
            this.Controls.Add(this.sysDNSServers);
            this.Controls.Add(this.sysGateway);
            this.Controls.Add(this.lblDns);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblIP);
            this.Name = "networkX";
            this.Text = "Network X";
            this.Load += new System.EventHandler(this.networkX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIP;
        private Label lblGateway;
        private Label lblDns;
        private Label sysGateway;
        private Label sysDNSServers;
        private Label sysIP;
        private Button checkNIC;
        private Label netXResult;
        private Button networkStatus;
        private Button flushDNS;
        private Button releaseRenewIP;
    }
}