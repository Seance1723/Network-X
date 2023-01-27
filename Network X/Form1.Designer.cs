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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(networkX));
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBandwidth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadSpeed = new System.Windows.Forms.Label();
            this.downloadSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIP.Location = new System.Drawing.Point(66, 34);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(93, 31);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "Your IP:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.BackColor = System.Drawing.Color.Transparent;
            this.lblGateway.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGateway.Location = new System.Drawing.Point(66, 88);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(162, 31);
            this.lblGateway.TabIndex = 1;
            this.lblGateway.Text = "Your Gateway:";
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.BackColor = System.Drawing.Color.Transparent;
            this.lblDns.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDns.Location = new System.Drawing.Point(66, 138);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(121, 31);
            this.lblDns.TabIndex = 2;
            this.lblDns.Text = "Your DNS:";
            // 
            // sysGateway
            // 
            this.sysGateway.AutoSize = true;
            this.sysGateway.BackColor = System.Drawing.Color.Transparent;
            this.sysGateway.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sysGateway.Location = new System.Drawing.Point(234, 91);
            this.sysGateway.Name = "sysGateway";
            this.sysGateway.Size = new System.Drawing.Size(89, 28);
            this.sysGateway.TabIndex = 3;
            this.sysGateway.Text = "Gateway";
            // 
            // sysDNSServers
            // 
            this.sysDNSServers.AutoSize = true;
            this.sysDNSServers.BackColor = System.Drawing.Color.Transparent;
            this.sysDNSServers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sysDNSServers.Location = new System.Drawing.Point(193, 140);
            this.sysDNSServers.Name = "sysDNSServers";
            this.sysDNSServers.Size = new System.Drawing.Size(52, 28);
            this.sysDNSServers.TabIndex = 4;
            this.sysDNSServers.Text = "DNS";
            // 
            // sysIP
            // 
            this.sysIP.AutoSize = true;
            this.sysIP.BackColor = System.Drawing.Color.Transparent;
            this.sysIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sysIP.Location = new System.Drawing.Point(165, 37);
            this.sysIP.Name = "sysIP";
            this.sysIP.Size = new System.Drawing.Size(30, 28);
            this.sysIP.TabIndex = 5;
            this.sysIP.Text = "IP";
            // 
            // checkNIC
            // 
            this.checkNIC.BackColor = System.Drawing.Color.MediumPurple;
            this.checkNIC.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.checkNIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNIC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkNIC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkNIC.Location = new System.Drawing.Point(67, 252);
            this.checkNIC.Name = "checkNIC";
            this.checkNIC.Size = new System.Drawing.Size(194, 55);
            this.checkNIC.TabIndex = 6;
            this.checkNIC.Text = "Check NIC";
            this.checkNIC.UseVisualStyleBackColor = false;
            this.checkNIC.Click += new System.EventHandler(this.checkNIC_Click);
            // 
            // netXResult
            // 
            this.netXResult.AutoSize = true;
            this.netXResult.BackColor = System.Drawing.Color.Transparent;
            this.netXResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.netXResult.Location = new System.Drawing.Point(67, 191);
            this.netXResult.Name = "netXResult";
            this.netXResult.Size = new System.Drawing.Size(67, 28);
            this.netXResult.TabIndex = 7;
            this.netXResult.Text = "Status";
            // 
            // networkStatus
            // 
            this.networkStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.networkStatus.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.networkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.networkStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.networkStatus.ForeColor = System.Drawing.Color.White;
            this.networkStatus.Location = new System.Drawing.Point(303, 252);
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(194, 55);
            this.networkStatus.TabIndex = 8;
            this.networkStatus.Text = "Network Status";
            this.networkStatus.UseVisualStyleBackColor = false;
            this.networkStatus.Click += new System.EventHandler(this.networkStatus_Click);
            // 
            // flushDNS
            // 
            this.flushDNS.BackColor = System.Drawing.Color.MediumPurple;
            this.flushDNS.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.flushDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flushDNS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flushDNS.ForeColor = System.Drawing.Color.White;
            this.flushDNS.Location = new System.Drawing.Point(539, 252);
            this.flushDNS.Name = "flushDNS";
            this.flushDNS.Size = new System.Drawing.Size(194, 55);
            this.flushDNS.TabIndex = 9;
            this.flushDNS.Text = "Flush DNS";
            this.flushDNS.UseVisualStyleBackColor = false;
            this.flushDNS.Click += new System.EventHandler(this.flushDNS_Click);
            // 
            // releaseRenewIP
            // 
            this.releaseRenewIP.BackColor = System.Drawing.Color.MediumPurple;
            this.releaseRenewIP.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.releaseRenewIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.releaseRenewIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.releaseRenewIP.ForeColor = System.Drawing.Color.White;
            this.releaseRenewIP.Location = new System.Drawing.Point(67, 340);
            this.releaseRenewIP.Name = "releaseRenewIP";
            this.releaseRenewIP.Size = new System.Drawing.Size(194, 55);
            this.releaseRenewIP.TabIndex = 10;
            this.releaseRenewIP.Text = "Release/Renew IP";
            this.releaseRenewIP.UseVisualStyleBackColor = false;
            this.releaseRenewIP.Click += new System.EventHandler(this.releaseRenewIP_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkBandwidth
            // 
            this.checkBandwidth.BackColor = System.Drawing.Color.MediumPurple;
            this.checkBandwidth.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.checkBandwidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBandwidth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBandwidth.ForeColor = System.Drawing.Color.White;
            this.checkBandwidth.Location = new System.Drawing.Point(303, 340);
            this.checkBandwidth.Name = "checkBandwidth";
            this.checkBandwidth.Size = new System.Drawing.Size(194, 55);
            this.checkBandwidth.TabIndex = 11;
            this.checkBandwidth.Text = "Check Bandwidth";
            this.checkBandwidth.UseVisualStyleBackColor = false;
            this.checkBandwidth.Click += new System.EventHandler(this.checkBandwidth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(641, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "0/MB";
            // 
            // uploadSpeed
            // 
            this.uploadSpeed.AutoSize = true;
            this.uploadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.uploadSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadSpeed.Location = new System.Drawing.Point(539, 34);
            this.uploadSpeed.Name = "uploadSpeed";
            this.uploadSpeed.Size = new System.Drawing.Size(96, 31);
            this.uploadSpeed.TabIndex = 13;
            this.uploadSpeed.Text = "Upload:";
            // 
            // downloadSpeed
            // 
            this.downloadSpeed.AutoSize = true;
            this.downloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.downloadSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downloadSpeed.Location = new System.Drawing.Point(508, 88);
            this.downloadSpeed.Name = "downloadSpeed";
            this.downloadSpeed.Size = new System.Drawing.Size(127, 31);
            this.downloadSpeed.TabIndex = 14;
            this.downloadSpeed.Text = "Download:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(641, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "0/MB";
            // 
            // networkX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downloadSpeed);
            this.Controls.Add(this.uploadSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBandwidth);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private ImageList imageList1;
        private Button checkBandwidth;
        private Label label1;
        private Label uploadSpeed;
        private Label downloadSpeed;
        private Label label4;
    }
}