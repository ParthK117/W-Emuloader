﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.load_boxart_on_startup = New System.Windows.Forms.CheckBox()
        Me.btn_save = New System.Windows.Forms.PictureBox()
        Me.load_skin = New System.Windows.Forms.CheckBox()
        Me.btn_lightmode = New System.Windows.Forms.PictureBox()
        Me.btn_darkmode = New System.Windows.Forms.PictureBox()
        Me.listbox_settings = New System.Windows.Forms.ListBox()
        Me.panel_general = New System.Windows.Forms.Panel()
        Me.lbl_settingstitle = New System.Windows.Forms.Label()
        Me.panel_appearance = New System.Windows.Forms.Panel()
        Me.panel_updates = New System.Windows.Forms.Panel()
        Me.checkbox_autoupdate = New System.Windows.Forms.CheckBox()
        Me.checkbox_exit_on_taskbar = New System.Windows.Forms.CheckBox()
        Me.checkbox_fancy = New System.Windows.Forms.CheckBox()
        Me.picturebox_wave = New System.Windows.Forms.PictureBox()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_lightmode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_darkmode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_general.SuspendLayout()
        Me.panel_appearance.SuspendLayout()
        Me.panel_updates.SuspendLayout()
        CType(Me.picturebox_wave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'load_boxart_on_startup
        '
        Me.load_boxart_on_startup.AutoSize = True
        Me.load_boxart_on_startup.Font = New System.Drawing.Font("Spartan MB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.load_boxart_on_startup.Location = New System.Drawing.Point(12, 13)
        Me.load_boxart_on_startup.Name = "load_boxart_on_startup"
        Me.load_boxart_on_startup.Size = New System.Drawing.Size(386, 30)
        Me.load_boxart_on_startup.TabIndex = 0
        Me.load_boxart_on_startup.Text = "Download boxart automatically if missing"
        Me.load_boxart_on_startup.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(733, 438)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(176, 48)
        Me.btn_save.TabIndex = 1
        Me.btn_save.TabStop = False
        '
        'load_skin
        '
        Me.load_skin.AutoSize = True
        Me.load_skin.Font = New System.Drawing.Font("Spartan MB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.load_skin.Location = New System.Drawing.Point(12, 13)
        Me.load_skin.Name = "load_skin"
        Me.load_skin.Size = New System.Drawing.Size(126, 30)
        Me.load_skin.TabIndex = 2
        Me.load_skin.Text = "Dark mode"
        Me.load_skin.UseVisualStyleBackColor = True
        '
        'btn_lightmode
        '
        Me.btn_lightmode.BackgroundImage = CType(resources.GetObject("btn_lightmode.BackgroundImage"), System.Drawing.Image)
        Me.btn_lightmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_lightmode.Location = New System.Drawing.Point(12, 49)
        Me.btn_lightmode.Name = "btn_lightmode"
        Me.btn_lightmode.Size = New System.Drawing.Size(271, 152)
        Me.btn_lightmode.TabIndex = 3
        Me.btn_lightmode.TabStop = False
        '
        'btn_darkmode
        '
        Me.btn_darkmode.BackgroundImage = CType(resources.GetObject("btn_darkmode.BackgroundImage"), System.Drawing.Image)
        Me.btn_darkmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_darkmode.Location = New System.Drawing.Point(308, 49)
        Me.btn_darkmode.Name = "btn_darkmode"
        Me.btn_darkmode.Size = New System.Drawing.Size(271, 152)
        Me.btn_darkmode.TabIndex = 4
        Me.btn_darkmode.TabStop = False
        '
        'listbox_settings
        '
        Me.listbox_settings.FormattingEnabled = True
        Me.listbox_settings.Items.AddRange(New Object() {"General", "Appearance", "Updates"})
        Me.listbox_settings.Location = New System.Drawing.Point(12, 12)
        Me.listbox_settings.Name = "listbox_settings"
        Me.listbox_settings.Size = New System.Drawing.Size(201, 472)
        Me.listbox_settings.TabIndex = 5
        '
        'panel_general
        '
        Me.panel_general.Controls.Add(Me.checkbox_exit_on_taskbar)
        Me.panel_general.Controls.Add(Me.load_boxart_on_startup)
        Me.panel_general.Location = New System.Drawing.Point(220, 60)
        Me.panel_general.Name = "panel_general"
        Me.panel_general.Size = New System.Drawing.Size(689, 372)
        Me.panel_general.TabIndex = 6
        '
        'lbl_settingstitle
        '
        Me.lbl_settingstitle.AutoSize = True
        Me.lbl_settingstitle.Font = New System.Drawing.Font("Gotham Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settingstitle.Location = New System.Drawing.Point(219, 12)
        Me.lbl_settingstitle.Name = "lbl_settingstitle"
        Me.lbl_settingstitle.Size = New System.Drawing.Size(165, 44)
        Me.lbl_settingstitle.TabIndex = 7
        Me.lbl_settingstitle.Text = "General"
        '
        'panel_appearance
        '
        Me.panel_appearance.Controls.Add(Me.picturebox_wave)
        Me.panel_appearance.Controls.Add(Me.checkbox_fancy)
        Me.panel_appearance.Controls.Add(Me.load_skin)
        Me.panel_appearance.Controls.Add(Me.btn_lightmode)
        Me.panel_appearance.Controls.Add(Me.btn_darkmode)
        Me.panel_appearance.Location = New System.Drawing.Point(220, 60)
        Me.panel_appearance.Name = "panel_appearance"
        Me.panel_appearance.Size = New System.Drawing.Size(689, 372)
        Me.panel_appearance.TabIndex = 8
        '
        'panel_updates
        '
        Me.panel_updates.Controls.Add(Me.checkbox_autoupdate)
        Me.panel_updates.Location = New System.Drawing.Point(220, 60)
        Me.panel_updates.Name = "panel_updates"
        Me.panel_updates.Size = New System.Drawing.Size(689, 372)
        Me.panel_updates.TabIndex = 9
        '
        'checkbox_autoupdate
        '
        Me.checkbox_autoupdate.AutoSize = True
        Me.checkbox_autoupdate.Location = New System.Drawing.Point(12, 13)
        Me.checkbox_autoupdate.Name = "checkbox_autoupdate"
        Me.checkbox_autoupdate.Size = New System.Drawing.Size(163, 17)
        Me.checkbox_autoupdate.TabIndex = 0
        Me.checkbox_autoupdate.Text = "Check for updates on startup"
        Me.checkbox_autoupdate.UseVisualStyleBackColor = True
        '
        'checkbox_exit_on_taskbar
        '
        Me.checkbox_exit_on_taskbar.AutoSize = True
        Me.checkbox_exit_on_taskbar.Font = New System.Drawing.Font("Spartan MB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_exit_on_taskbar.Location = New System.Drawing.Point(12, 49)
        Me.checkbox_exit_on_taskbar.Name = "checkbox_exit_on_taskbar"
        Me.checkbox_exit_on_taskbar.Size = New System.Drawing.Size(386, 56)
        Me.checkbox_exit_on_taskbar.TabIndex = 1
        Me.checkbox_exit_on_taskbar.Text = "Checked: Pressing 'X' moves to taskbar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unchecked: Pressing 'X' closes emuloader"
        Me.checkbox_exit_on_taskbar.UseVisualStyleBackColor = True
        '
        'checkbox_fancy
        '
        Me.checkbox_fancy.AutoSize = True
        Me.checkbox_fancy.Font = New System.Drawing.Font("Spartan MB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_fancy.Location = New System.Drawing.Point(12, 207)
        Me.checkbox_fancy.Name = "checkbox_fancy"
        Me.checkbox_fancy.Size = New System.Drawing.Size(438, 30)
        Me.checkbox_fancy.TabIndex = 5
        Me.checkbox_fancy.Text = "Fancy download animations (30MB download)"
        Me.checkbox_fancy.UseVisualStyleBackColor = True
        '
        'picturebox_wave
        '
        Me.picturebox_wave.BackgroundImage = CType(resources.GetObject("picturebox_wave.BackgroundImage"), System.Drawing.Image)
        Me.picturebox_wave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox_wave.Location = New System.Drawing.Point(12, 244)
        Me.picturebox_wave.Name = "picturebox_wave"
        Me.picturebox_wave.Size = New System.Drawing.Size(567, 109)
        Me.picturebox_wave.TabIndex = 6
        Me.picturebox_wave.TabStop = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 498)
        Me.Controls.Add(Me.lbl_settingstitle)
        Me.Controls.Add(Me.listbox_settings)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.panel_appearance)
        Me.Controls.Add(Me.panel_general)
        Me.Controls.Add(Me.panel_updates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "settings"
        Me.Text = "Settings"
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_lightmode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_darkmode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_general.ResumeLayout(False)
        Me.panel_general.PerformLayout()
        Me.panel_appearance.ResumeLayout(False)
        Me.panel_appearance.PerformLayout()
        Me.panel_updates.ResumeLayout(False)
        Me.panel_updates.PerformLayout()
        CType(Me.picturebox_wave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents load_boxart_on_startup As CheckBox
    Friend WithEvents btn_save As PictureBox
    Friend WithEvents load_skin As CheckBox
    Friend WithEvents btn_lightmode As PictureBox
    Friend WithEvents btn_darkmode As PictureBox
    Friend WithEvents listbox_settings As ListBox
    Friend WithEvents panel_general As Panel
    Friend WithEvents lbl_settingstitle As Label
    Friend WithEvents panel_appearance As Panel
    Friend WithEvents panel_updates As Panel
    Friend WithEvents checkbox_autoupdate As CheckBox
    Friend WithEvents checkbox_exit_on_taskbar As CheckBox
    Friend WithEvents checkbox_fancy As CheckBox
    Friend WithEvents picturebox_wave As PictureBox
End Class
