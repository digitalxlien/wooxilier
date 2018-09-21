Imports System.IO


Public Class frmStart

    'Loader de formulario
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxCerosIzq.Text = cboxCerosIzq.Items(0)
    End Sub

    'Funcion que lleva a cabo la cadena final de los folios
    Private Function makeFolios(folioInicio As Integer, totalFolios As Decimal, factor As Integer, cerosIzq As Integer) As String

        Dim bloc As Decimal
        Dim columna As Integer()
        Dim s As String = ""




        bloc = (totalFolios - folioInicio) / factor
        bloc = Math.Ceiling(bloc)
        totalFolios = bloc * factor


        'Apertura del archivo
        s = s & factor & vbCrLf

        'Acciones para realizar los nombre de columnas en el archivo final:
        Dim cont As Integer = folioInicio - 1
        For x As Integer = 0 To factor - 1
            s = s & String.Format("\{0:D" + cerosIzq.ToString + "}-{1:D" + cerosIzq.ToString + "}=0,{0}.000000,{1}.000000,{2}\" & vbCrLf, cont + 1, CType(cont + bloc, Integer), cerosIzq)
            cont = cont + bloc
        Next

        'Creacion de arreglo dinamico
        ReDim columna(factor - 1)

        'Inicializacion del arreglo
        columna(0) = folioInicio
        For x = 1 To factor - 1
            columna(x) = columna(x - 1) + bloc
        Next

        'Sumatoria de columnas
        For i = 0 To bloc - 1
            For x = 0 To factor - 1
                s = s & String.Format("\{0:D" + (cerosIzq + 1).ToString + "}\", CType(columna(x) + i, Integer))
            Next
            s = s & vbCrLf
        Next

        Return s
    End Function

    'Acciones que realiza el boton Generar
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim factor, cerosIzq, folioInicio As Integer
        Dim totalFolios As Decimal
        Dim nombreArchivo As String = ""

        If (isNumber(txtTotalFolios.Text) And isNumber(txtFactor.Text) And isNumber(txtFolioInicio.Text)) Then
            If (Integer.Parse(txtFolioInicio.Text) < Integer.Parse(txtTotalFolios.Text)) Then



                factor = txtFactor.Text
                cerosIzq = cboxCerosIzq.SelectedIndex + 1
                folioInicio = txtFolioInicio.Text
                totalFolios = txtTotalFolios.Text
                'Console.Write(makeFolios(factor, cerosIzq, totalFolios))

                'REALIZAR ACCION DE GARDADO

                dialogoGuardar.Title = "Guardar documento de fusion"
                dialogoGuardar.FileName = "Archivo de fusion del " & folioInicio & " al " & totalFolios & " para " & factor
                dialogoGuardar.Filter = "Archivos de texto (*.txt)|*.txt"
                dialogoGuardar.ShowDialog()
                nombreArchivo = dialogoGuardar.FileName

                GuardarArchivo(makeFolios(folioInicio, totalFolios, factor, cerosIzq), nombreArchivo)
                MessageBox.Show("Se ha guardado su archivo para fusion exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El numero inicial es mayor al numero final de folios. Verifique sus datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Ingrese valores validos en las cajas de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        txtFolioInicio.Text = ""
        txtFactor.Text = ""
        txtTotalFolios.Text = ""
    End Sub

    Private Function GuardarArchivo(s As String, nombreArchivo As String) As Boolean
        Dim fs As FileStream = Nothing
        Dim sw As StreamWriter = Nothing

        Try


            If nombreArchivo <> "" Then


                fs = New FileStream(nombreArchivo, FileMode.Create, FileAccess.Write)
                sw = New StreamWriter(fs)
                sw.Write(s)
            End If


            Return True
        Catch ex As Exception
            MessageBox.Show("Hubo un error al momento de guardar el archivo." & vbCrLf & vbCrLf &
                            "Detalles del error: " & vbCrLf & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        Finally
            If (Not sw Is Nothing) Then
                sw.Close()
            End If
            If (Not fs Is Nothing) Then
                fs.Close()
            End If
        End Try




    End Function


    'Evalua si la cadena recibida es un numero
    Private Function isNumber(s As String) As Boolean
        Try
            Integer.Parse(s)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Boton de Salir. Cierra el programa
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    'ComboBox de ceros a la izquierda: Hace que el combobox no sea editable
    Private Sub cboxCerosIzq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxCerosIzq.KeyPress
        e.Handled = True
    End Sub

    'KeyListener para validar txtTotalFolios
    Private Sub txtTotalFolios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalFolios.KeyPress
        Dim CadenaValida As String = "0123456789"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    'KeyListener para validar txtFactor
    Private Sub txtFactor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactor.KeyPress
        Dim CadenaValida As String = "0123456789"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
    Private Sub txtFolioInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolioInicio.KeyPress
        Dim CadenaValida As String = "0123456789"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.ShowDialog()
    End Sub


End Class
