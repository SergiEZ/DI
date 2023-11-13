Public Class Producto
    Public Property Nombre As String
    Public Property Cantidad As Integer
    Public Property Precio As Decimal

    Public ReadOnly Property Total As Decimal
        Get
            Return Cantidad * Precio
        End Get
    End Property

    Public Sub New(nombre As String, cantidad As Integer, precio As Decimal)
        Me.Nombre = nombre
        Me.Cantidad = cantidad
        Me.Precio = precio
    End Sub
End Class