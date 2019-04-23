<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lvMods = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUnArchive = New System.Windows.Forms.Button()
        Me.btnDelArch = New System.Windows.Forms.Button()
        Me.lvArchive = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLuckDel = New System.Windows.Forms.Button()
        Me.lvLuckyBlocks = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddMod = New System.Windows.Forms.Button()
        Me.btnAddLB = New System.Windows.Forms.Button()
        Me.ofdLuck = New System.Windows.Forms.OpenFileDialog()
        Me.ofdMods = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvMods
        '
        Me.lvMods.FormattingEnabled = True
        Me.lvMods.ItemHeight = 16
        Me.lvMods.Location = New System.Drawing.Point(8, 21)
        Me.lvMods.Name = "lvMods"
        Me.lvMods.Size = New System.Drawing.Size(281, 340)
        Me.lvMods.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnArchive)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lvMods)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 502)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mods Folder"
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnArchive.Location = New System.Drawing.Point(6, 433)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(281, 60)
        Me.btnArchive.TabIndex = 3
        Me.btnArchive.Text = "ARCHIVE"
        Me.btnArchive.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(6, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(281, 60)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUnArchive)
        Me.GroupBox2.Controls.Add(Me.btnDelArch)
        Me.GroupBox2.Controls.Add(Me.lvArchive)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 502)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Archived Mods"
        '
        'btnUnArchive
        '
        Me.btnUnArchive.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnUnArchive.Location = New System.Drawing.Point(8, 433)
        Me.btnUnArchive.Name = "btnUnArchive"
        Me.btnUnArchive.Size = New System.Drawing.Size(281, 60)
        Me.btnUnArchive.TabIndex = 4
        Me.btnUnArchive.Text = "UNARCHIVE"
        Me.btnUnArchive.UseVisualStyleBackColor = False
        '
        'btnDelArch
        '
        Me.btnDelArch.BackColor = System.Drawing.Color.Red
        Me.btnDelArch.Location = New System.Drawing.Point(6, 367)
        Me.btnDelArch.Name = "btnDelArch"
        Me.btnDelArch.Size = New System.Drawing.Size(281, 60)
        Me.btnDelArch.TabIndex = 4
        Me.btnDelArch.Text = "DELETE"
        Me.btnDelArch.UseVisualStyleBackColor = False
        '
        'lvArchive
        '
        Me.lvArchive.FormattingEnabled = True
        Me.lvArchive.ItemHeight = 16
        Me.lvArchive.Location = New System.Drawing.Point(6, 21)
        Me.lvArchive.Name = "lvArchive"
        Me.lvArchive.Size = New System.Drawing.Size(281, 340)
        Me.lvArchive.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnLuckDel)
        Me.GroupBox3.Controls.Add(Me.lvLuckyBlocks)
        Me.GroupBox3.Location = New System.Drawing.Point(614, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 502)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lucky Block Addons"
        '
        'btnLuckDel
        '
        Me.btnLuckDel.BackColor = System.Drawing.Color.Red
        Me.btnLuckDel.Location = New System.Drawing.Point(6, 367)
        Me.btnLuckDel.Name = "btnLuckDel"
        Me.btnLuckDel.Size = New System.Drawing.Size(281, 60)
        Me.btnLuckDel.TabIndex = 4
        Me.btnLuckDel.Text = "DELETE"
        Me.btnLuckDel.UseVisualStyleBackColor = False
        '
        'lvLuckyBlocks
        '
        Me.lvLuckyBlocks.FormattingEnabled = True
        Me.lvLuckyBlocks.ItemHeight = 16
        Me.lvLuckyBlocks.Location = New System.Drawing.Point(6, 21)
        Me.lvLuckyBlocks.Name = "lvLuckyBlocks"
        Me.lvLuckyBlocks.Size = New System.Drawing.Size(281, 340)
        Me.lvLuckyBlocks.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(6, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 51)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Currently no support for archiving lucky block" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mods. Hopefully this will become " &
    "a feature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in future versions."
        '
        'btnAddMod
        '
        Me.btnAddMod.BackColor = System.Drawing.Color.LawnGreen
        Me.btnAddMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMod.Location = New System.Drawing.Point(12, 12)
        Me.btnAddMod.Name = "btnAddMod"
        Me.btnAddMod.Size = New System.Drawing.Size(795, 74)
        Me.btnAddMod.TabIndex = 6
        Me.btnAddMod.Text = "ADD A MOD"
        Me.btnAddMod.UseVisualStyleBackColor = False
        '
        'btnAddLB
        '
        Me.btnAddLB.BackColor = System.Drawing.Color.Yellow
        Me.btnAddLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLB.Location = New System.Drawing.Point(813, 12)
        Me.btnAddLB.Name = "btnAddLB"
        Me.btnAddLB.Size = New System.Drawing.Size(96, 74)
        Me.btnAddLB.TabIndex = 7
        Me.btnAddLB.Text = "?"
        Me.btnAddLB.UseVisualStyleBackColor = False
        '
        'ofdLuck
        '
        Me.ofdLuck.FileName = "OpenFileDialog1"
        Me.ofdLuck.InitialDirectory = "C:\Users\Ataul\AppData\Roaming\.minecraft\addons\lucky_block\"
        '
        'ofdMods
        '
        Me.ofdMods.FileName = "OpenFileDialog1"
        Me.ofdMods.InitialDirectory = "C:\Users\Ataul\AppData\Roaming\.minecraft\mods\"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 617)
        Me.Controls.Add(Me.btnAddLB)
        Me.Controls.Add(Me.btnAddMod)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Mods Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvMods As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnArchive As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUnArchive As Button
    Friend WithEvents btnDelArch As Button
    Friend WithEvents lvArchive As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLuckDel As Button
    Friend WithEvents lvLuckyBlocks As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddMod As Button
    Friend WithEvents btnAddLB As Button
    Friend WithEvents ofdLuck As OpenFileDialog
    Friend WithEvents ofdMods As OpenFileDialog
End Class
