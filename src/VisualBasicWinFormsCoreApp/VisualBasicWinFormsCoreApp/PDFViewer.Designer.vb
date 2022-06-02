<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFViewer
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
        Me.KryptonDataGridView1 = New Krypton.Toolkit.KryptonDataGridView()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.ColumnHeadersHeight = 36
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(36, 65)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.RowHeadersWidth = 51
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(300, 188)
        Me.KryptonDataGridView1.TabIndex = 0
        '
        'PDFViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.KryptonDataGridView1)
        Me.Name = "PDFViewer"
        Me.Text = "PDFViewer"
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonDataGridView1 As Krypton.Toolkit.KryptonDataGridView
End Class
