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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcreatedat = New System.Windows.Forms.Label()
        Me.lblcreatedby = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtcreatedat = New System.Windows.Forms.TextBox()
        Me.txtcreatedby = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnpdf = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 639)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1081, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1081, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1081, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id"
        '
        'lblcreatedat
        '
        Me.lblcreatedat.AutoSize = True
        Me.lblcreatedat.Location = New System.Drawing.Point(1081, 195)
        Me.lblcreatedat.Name = "lblcreatedat"
        Me.lblcreatedat.Size = New System.Drawing.Size(80, 20)
        Me.lblcreatedat.TabIndex = 4
        Me.lblcreatedat.Text = "Created At"
        '
        'lblcreatedby
        '
        Me.lblcreatedby.AutoSize = True
        Me.lblcreatedby.Location = New System.Drawing.Point(1081, 248)
        Me.lblcreatedby.Name = "lblcreatedby"
        Me.lblcreatedby.Size = New System.Drawing.Size(81, 20)
        Me.lblcreatedby.TabIndex = 5
        Me.lblcreatedby.Text = "Created By"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(1175, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(349, 27)
        Me.txtid.TabIndex = 6
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(1175, 72)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(349, 27)
        Me.txtemail.TabIndex = 7
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(1175, 132)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(349, 27)
        Me.txtpass.TabIndex = 8
        '
        'txtcreatedat
        '
        Me.txtcreatedat.Location = New System.Drawing.Point(1175, 192)
        Me.txtcreatedat.Name = "txtcreatedat"
        Me.txtcreatedat.ReadOnly = True
        Me.txtcreatedat.Size = New System.Drawing.Size(349, 27)
        Me.txtcreatedat.TabIndex = 9
        '
        'txtcreatedby
        '
        Me.txtcreatedby.Location = New System.Drawing.Point(1175, 241)
        Me.txtcreatedby.Name = "txtcreatedby"
        Me.txtcreatedby.ReadOnly = True
        Me.txtcreatedby.Size = New System.Drawing.Size(349, 27)
        Me.txtcreatedby.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(1175, 284)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 29)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "Add User"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(1277, 284)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(90, 29)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear Form"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnpdf)
        Me.GroupBox1.Location = New System.Drawing.Point(1081, 345)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 111)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnpdf
        '
        Me.btnpdf.Location = New System.Drawing.Point(23, 40)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(167, 29)
        Me.btnpdf.TabIndex = 0
        Me.btnpdf.Text = "Export To PDF"
        Me.btnpdf.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Location = New System.Drawing.Point(1373, 284)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 29)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "Delete User"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1536, 663)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtcreatedby)
        Me.Controls.Add(Me.txtcreatedat)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblcreatedby)
        Me.Controls.Add(Me.lblcreatedat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcreatedat As Label
    Friend WithEvents lblcreatedby As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtcreatedat As TextBox
    Friend WithEvents txtcreatedby As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnpdf As Button
    Friend WithEvents btndelete As Button
End Class
