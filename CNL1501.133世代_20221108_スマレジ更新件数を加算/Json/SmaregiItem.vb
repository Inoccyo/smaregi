Imports System.Collections.Generic

Namespace Json

#Region "�p�����[�^���"

    <System.Runtime.Serialization.DataContract()> _
    <System.Runtime.Serialization.KnownType(GetType(proc_info_proc_division))> _
    <System.Runtime.Serialization.KnownType(GetType(data_rows))> _
    Public Class SmaregiRefParamsJson

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="proc_info", Order:=0)> _
        Public proc_info As New List(Of Object)

        <System.Runtime.Serialization.DataMember(Name:="data", Order:=1)> _
        Public data As New List(Of Object)

    End Class

    <System.Runtime.Serialization.DataContract()> _
    <System.Runtime.Serialization.KnownType(GetType(rows_productId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_categoryId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_productCode))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_productName))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_taxDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_price))> _
    Public Class SmaregiRefParamsJsonRows

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="table_name", Order:=0)> _
        Public table_name As String

        <System.Runtime.Serialization.DataMember(Name:="rows", Order:=1)> _
        Public rows As New List(Of Object)

    End Class

    <System.Runtime.Serialization.DataContract()> _
    <System.Runtime.Serialization.KnownType(GetType(rowsPrice_productId))> _
    <System.Runtime.Serialization.KnownType(GetType(rowsPrice_storeId))> _
    <System.Runtime.Serialization.KnownType(GetType(rowsPrice_priceDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rowsPrice_startDate))> _
    <System.Runtime.Serialization.KnownType(GetType(rowsPrice_price))> _
    Public Class SmaregiRefParamsJsonRowsPrice

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="table_name", Order:=0)> _
        Public table_name As String

        <System.Runtime.Serialization.DataMember(Name:="rows", Order:=1)> _
        Public rows As New List(Of Object)

    End Class

#End Region

#Region "proc_info�p"

    ''' <summary>
    ''' �����敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class proc_info_proc_division

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="proc_division")> _
        Public proc_division As String

    End Class

    ''' <summary>
    ''' �f�[�^
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class data_rows

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="data")> _
        Public data As String

    End Class

#End Region

#Region "rows�iProduct�j�p"

    ''' <summary>
    ''' ���iID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_productId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="productId")> _
        Public productId As String

    End Class

    ''' <summary>
    ''' ����ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_categoryId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="categoryId")> _
        Public categoryId As String

    End Class

    ''' <summary>
    ''' ���i�R�[�h
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_productCode

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="productCode")> _
        Public productCode As String

    End Class

    ''' <summary>
    ''' ���i��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_productName

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="productName")> _
        Public productName As String

    End Class

    ''' <summary>
    ''' �ŋ敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_taxDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="taxDivision")> _
        Public taxDivision As String

    End Class

    ''' <summary>
    ''' ���i���i�敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_productPriceDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="productPriceDivision")> _
        Public productPriceDivision As String

    End Class

    ''' <summary>
    ''' ���i�P��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_price

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="price")> _
        Public price As String

    End Class

    ''' <summary>
    ''' ����̐Őݒ�g�p�L��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_useCategoryReduceTax

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="useCategoryReduceTax")> _
        Public useCategoryReduceTax As String

    End Class

    ''' <summary>
    ''' �y���ŗ�ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_reduceTaxId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="reduceTaxId")> _
        Public reduceTaxId As String

    End Class

#End Region

#Region "rows�iProductPrice�j�p"

    ''' <summary>
    ''' ���iID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rowsPrice_productId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="productId")> _
        Public price_productId As String

    End Class

    ''' <summary>
    ''' �X��ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rowsPrice_storeId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="storeId")> _
        Public Price_storeId As String

    End Class

    ''' <summary>
    ''' ���i�敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rowsPrice_priceDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="priceDivision")> _
        Public Price_priceDivision As String

    End Class

    ''' <summary>
    ''' �K�p�J�n��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rowsPrice_startDate

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="startDate")> _
        Public Price_startDate As String

    End Class

    ''' <summary>
    ''' ���i�P��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rowsPrice_price

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="price")> _
        Public Price_price As String

    End Class

#End Region

#Region "���i�e�[�u��"

    ''' <summary>
    ''' �X�}���W�擾���^(���i�e�[�u���p)
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
       Public Class transactionGetDataMain_Product

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="result")> Public result As New List(Of transactionGetDataProduct)

    End Class

    ''' <summary>
    ''' �X�}���W���i�e�[�u���^
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class transactionGetDataProduct

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="Product")> Public Product As String
        <System.Runtime.Serialization.DataMember(Name:="ProductPrice")> Public ProductPrice As String
        <System.Runtime.Serialization.DataMember(Name:="ProductReserveItem")> Public ProductReserveItem As String
        <System.Runtime.Serialization.DataMember(Name:="ProductReserveItemLabel")> Public ProductReserveItemLabel As String
        <System.Runtime.Serialization.DataMember(Name:="ProductStore")> Public ProductStore As String
        <System.Runtime.Serialization.DataMember(Name:="ProductInventoryReservation")> Public ProductInventoryReservation As String

    End Class

#End Region

#Region "�G���[���"

    ''' <summary>
    ''' �G���[���^
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class errorInfo

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="error_code")> Public error_code As String
        <System.Runtime.Serialization.DataMember(Name:="error")> Public errorM As String
        <System.Runtime.Serialization.DataMember(Name:="error_description")> Public error_description As String

    End Class

#End Region

End Namespace
