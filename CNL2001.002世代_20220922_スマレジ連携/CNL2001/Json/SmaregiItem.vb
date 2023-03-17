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
    <System.Runtime.Serialization.KnownType(GetType(rows_transactionHeadDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_cancelDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_subtotal))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_total))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_storeId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_taxExclude))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_taxInclude))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_terminalId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_terminalTranId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_terminalTranDateTime))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_memo))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_guestNumbers))> _
    Public Class SmaregiRefParamsJsonRowsHead

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="table_name", Order:=0)> _
        Public table_name As String

        <System.Runtime.Serialization.DataMember(Name:="rows", Order:=1)> _
        Public rows As New List(Of Object)

    End Class

    <System.Runtime.Serialization.DataContract()> _
    <System.Runtime.Serialization.KnownType(GetType(rows_transactionDetailDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_productId))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_taxDivision))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_salesPrice))> _
    <System.Runtime.Serialization.KnownType(GetType(rows_quantity))> _
    Public Class SmaregiRefParamsJsonRowsDetail

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

#Region "rows�iHead�j�p"

    ''' <summary>
    ''' ����敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_transactionHeadDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="transactionHeadDivision")> _
        Public transactionHeadDivision As String

    End Class

    ''' <summary>
    ''' ����敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_cancelDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="cancelDivision")> _
        Public cancelDivision As String

    End Class

    ''' <summary>
    ''' ���v
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_subtotal

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="subtotal")> _
        Public subtotal As String

    End Class

    ''' <summary>
    ''' ���v
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_total

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="total")> _
        Public total As String

    End Class

    ''' <summary>
    ''' �O�Ŋz
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_taxExclude

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="taxExclude")> _
        Public taxExclude As String

    End Class

    ''' <summary>
    ''' ���Ŋz
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_taxInclude

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="taxInclude")> _
        Public taxInclude As String

    End Class

    ''' <summary>
    ''' �X��ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_storeId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="storeId")> _
        Public storeId As String

    End Class

    ''' <summary>
    ''' �[��ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_terminalId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="terminalId")> _
        Public terminalId As String

    End Class

    ''' <summary>
    ''' �[�����ID
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_terminalTranId

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="terminalTranId")> _
        Public terminalTranId As String

    End Class

    ''' <summary>
    ''' �[���������
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_terminalTranDateTime

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="terminalTranDateTime")> _
        Public terminalTranDateTime As String

    End Class

    ''' <summary>
    ''' ����
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_memo

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="memo")> _
        Public memo As String

    End Class

    ''' <summary>
    ''' �q��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_guestNumbers

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="guestNumbers")> _
        Public guestNumbers As String

    End Class

#End Region

#Region "rows�iDetail�j�p"

    ''' <summary>
    ''' ������׋敪
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_transactionDetailDivision

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="transactionDetailDivision")> _
        Public transactionDetailDivision As String

    End Class

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
    ''' �̔��P��
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_salesPrice

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="salesPrice")> _
        Public salesPrice As String

    End Class

    ''' <summary>
    ''' ����
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class rows_quantity

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="quantity")> _
        Public quantity As String

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

#Region "����e�[�u��"

    ''' <summary>
    ''' �X�}���W�擾���^(����e�[�u���p)
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
       Public Class transactionGetData_Transaction

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="result")> Public result As New List(Of transactionGetDataTransaction)

    End Class

    ''' <summary>
    ''' �X�}���W����e�[�u���^
    ''' </summary>
    ''' <remarks></remarks>
    <System.Runtime.Serialization.DataContract()> _
    Public Class transactionGetDataTransaction

        Public Sub New()

        End Sub

        <System.Runtime.Serialization.DataMember(Name:="TransactionHead")> Public TransactionHead As String
        <System.Runtime.Serialization.DataMember(Name:="TransactionDetail")> Public TransactionDetail As String
        <System.Runtime.Serialization.DataMember(Name:="TransactionHeadIds")> Public TransactionHeadIds As String

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
