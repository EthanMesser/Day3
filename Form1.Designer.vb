<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ContestantPool = New System.Windows.Forms.ListBox()
        Me.PlayerDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EthansDBDataSet = New Day3.EthansDBDataSet()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PlayerDBTableAdapter = New Day3.EthansDBDataSetTableAdapters.PlayerDBTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PlayerDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthansDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContestantPool
        '
        Me.ContestantPool.DataSource = Me.PlayerDBBindingSource
        Me.ContestantPool.DisplayMember = "Playername"
        Me.ContestantPool.FormattingEnabled = True
        Me.ContestantPool.Location = New System.Drawing.Point(12, 61)
        Me.ContestantPool.Name = "ContestantPool"
        Me.ContestantPool.Size = New System.Drawing.Size(304, 264)
        Me.ContestantPool.TabIndex = 0
        Me.ContestantPool.ValueMember = "GamerTag"
        '
        'PlayerDBBindingSource
        '
        Me.PlayerDBBindingSource.DataMember = "PlayerDB"
        Me.PlayerDBBindingSource.DataSource = Me.EthansDBDataSet
        '
        'EthansDBDataSet
        '
        Me.EthansDBDataSet.DataSetName = "EthansDBDataSet"
        Me.EthansDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(492, 61)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(232, 264)
        Me.ListBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 407)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 407)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = ">> Submit into Bracket >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Add new Gamer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name of contestant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contestant GameTag"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contestant Pool"
        '
        'PlayerDBTableAdapter
        '
        Me.PlayerDBTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tournament Finalists"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(651, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Finalize Bracket"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 530)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ContestantPool)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PlayerDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthansDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContestantPool As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EthansDBDataSet As EthansDBDataSet
    Friend WithEvents PlayerDBBindingSource As BindingSource
    Friend WithEvents PlayerDBTableAdapter As EthansDBDataSetTableAdapters.PlayerDBTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
