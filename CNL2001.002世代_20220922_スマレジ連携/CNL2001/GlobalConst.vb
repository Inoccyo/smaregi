Public Class GlobalConst

    'シーケンサから受信する電文における最大点数
    Public Const MaxCnt As Integer = 256

    'DBのUPDIDに更新する値
    Public Const UPDID As String = "LANE_CTL"

    '配列第2要素の用途
    Public Const C_DEVICE As Integer = 0            'デバイスID
    Public Const C_LR As Integer = 1                '左右レーン
    Public Const C_UD As Integer = 2                '上下レーン
    Public Const C_SEAT As Integer = 3              '座席ID
    Public Const C_TYPE As Integer = 4              'シーケンスタイプ

    'シーケンスタイプの種類
    Public Const C_START As String = "0"            '出発指示
    Public Const C_ARRIVAL As String = "1"          '到着予告
    Public Const C_RETURN As String = "2"           '返却指示（客席）
    Public Const C_KC_RET As String = "3"           '返却指示（厨房）
    Public Const C_RUN As String = "4"              'モーター稼働ステータス
    Public Const C_ERR As String = "5"              'レーン異常ステータス
    Public Const C_RECV As String = "6"             '商品取残ステータス

    'デバイスIDを格納する配列
    Public GC As ArrayList

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        GC = New ArrayList

        '*************************************************************************************************************
        'シーケンスタイプ「C_RETURN」について
        '客席からの返却指示の際に使用するタイプ
        '客席からの返却機能を使用する場合は配列内のどこかに必要なので注意すること
        '*************************************************************************************************************

        '*************************************************************************************************************
        'シーケンスタイプ「C_KC_RET」について
        '厨房からの返却指示の際に使用するタイプとなるが、実際はシーケンサに対して送信する電文にはならない
        '該当レーンのシーケンスタイプ「C_RETURN」の先頭を探し、そこのデバイスIDにて返却指示が電文となる仕組みとなる
        'よって、レーン仕様書には「C_KC_RET」に対しての仕様は記載されないが、厨房からの返却機能を使用する場合は
        '配列内のどこかに必要なので注意すること
        '*************************************************************************************************************

        'デバイスID配列の初期化
        '全256行
        '要素は「デバイスID」、「左右レーン」、「上下レーン」、「座席ID」、「シーケンスタイプ」
        GC.Add(New String() {"M*000100", "1", "1", "1", C_START})
        GC.Add(New String() {"M*000101", "1", "1", "1", C_ARRIVAL})
        GC.Add(New String() {"M*000102", "1", "1", "2", C_START})
        GC.Add(New String() {"M*000103", "1", "1", "2", C_ARRIVAL})
        GC.Add(New String() {"M*000104", "1", "1", "3", C_START})
        GC.Add(New String() {"M*000105", "1", "1", "3", C_ARRIVAL})
        GC.Add(New String() {"M*000106", "1", "1", "4", C_START})
        GC.Add(New String() {"M*000107", "1", "1", "4", C_ARRIVAL})
        GC.Add(New String() {"M*000108", "1", "1", "5", C_START})
        GC.Add(New String() {"M*000109", "1", "1", "5", C_ARRIVAL})
        GC.Add(New String() {"M*000110", "1", "1", "6", C_START})
        GC.Add(New String() {"M*000111", "1", "1", "6", C_ARRIVAL})
        GC.Add(New String() {"M*000112", "1", "1", "7", C_START})
        GC.Add(New String() {"M*000113", "1", "1", "7", C_ARRIVAL})
        GC.Add(New String() {"M*000114", "1", "1", "8", C_START})
        GC.Add(New String() {"M*000115", "1", "1", "8", C_ARRIVAL})
        GC.Add(New String() {"M*000116", "1", "1", "9", C_START})
        GC.Add(New String() {"M*000117", "1", "1", "9", C_ARRIVAL})
        GC.Add(New String() {"M*000118", "1", "1", "10", C_START})
        GC.Add(New String() {"M*000119", "1", "1", "10", C_ARRIVAL})
        GC.Add(New String() {"M*000120", "1", "1", "11", C_START})
        GC.Add(New String() {"M*000121", "1", "1", "11", C_ARRIVAL})
        GC.Add(New String() {"M*000122", "1", "1", "12", C_START})
        GC.Add(New String() {"M*000123", "1", "1", "12", C_ARRIVAL})
        GC.Add(New String() {"M*000124", "1", "1", "13", C_START})
        GC.Add(New String() {"M*000125", "1", "1", "13", C_ARRIVAL})
        GC.Add(New String() {"M*000126", "1", "1", "14", C_START})
        GC.Add(New String() {"M*000127", "1", "1", "14", C_ARRIVAL})
        GC.Add(New String() {"M*000128", "1", "1", "15", C_START})
        GC.Add(New String() {"M*000129", "1", "1", "15", C_ARRIVAL})
        GC.Add(New String() {"M*000130", "1", "1", "16", C_START})
        GC.Add(New String() {"M*000131", "1", "1", "16", C_ARRIVAL})
        GC.Add(New String() {"M*000132", "1", "1", "17", C_START})
        GC.Add(New String() {"M*000133", "1", "1", "17", C_ARRIVAL})
        GC.Add(New String() {"M*000134", "1", "1", "18", C_START})
        GC.Add(New String() {"M*000135", "1", "1", "18", C_ARRIVAL})
        GC.Add(New String() {"M*000136", "1", "1", "19", C_START})
        GC.Add(New String() {"M*000137", "1", "1", "19", C_ARRIVAL})
        GC.Add(New String() {"M*000138", "1", "1", "20", C_START})
        GC.Add(New String() {"M*000139", "1", "1", "20", C_ARRIVAL})
        GC.Add(New String() {"M*000140", "1", "1", "21", C_START})
        GC.Add(New String() {"M*000141", "1", "1", "21", C_ARRIVAL})
        GC.Add(New String() {"M*000142", "", "", "", ""})
        GC.Add(New String() {"M*000143", "", "", "", ""})
        GC.Add(New String() {"M*000144", "", "", "", ""})
        GC.Add(New String() {"M*000145", "", "", "", ""})
        GC.Add(New String() {"M*000146", "", "", "", ""})
        GC.Add(New String() {"M*000147", "", "", "", ""})
        GC.Add(New String() {"M*000148", "", "", "", ""})
        GC.Add(New String() {"M*000149", "", "", "", ""})
        GC.Add(New String() {"M*000150", "", "", "", ""})
        GC.Add(New String() {"M*000151", "", "", "", ""})
        GC.Add(New String() {"M*000152", "", "", "", ""})
        GC.Add(New String() {"M*000153", "", "", "", ""})
        GC.Add(New String() {"M*000154", "", "", "", ""})
        GC.Add(New String() {"M*000155", "", "", "", ""})
        GC.Add(New String() {"M*000156", "", "", "", ""})
        GC.Add(New String() {"M*000157", "", "", "", ""})
        GC.Add(New String() {"M*000158", "", "", "", ""})
        GC.Add(New String() {"M*000159", "", "", "", ""})
        GC.Add(New String() {"M*000160", "", "", "", ""})
        GC.Add(New String() {"M*000161", "", "", "", ""})
        GC.Add(New String() {"M*000162", "", "", "", ""})
        GC.Add(New String() {"M*000163", "", "", "", ""})
        GC.Add(New String() {"M*000164", "", "", "", ""})
        GC.Add(New String() {"M*000165", "", "", "", ""})
        GC.Add(New String() {"M*000166", "", "", "", ""})
        GC.Add(New String() {"M*000167", "", "", "", ""})
        GC.Add(New String() {"M*000168", "", "", "", ""})
        GC.Add(New String() {"M*000169", "", "", "", ""})
        GC.Add(New String() {"M*000170", "", "", "", ""})
        GC.Add(New String() {"M*000171", "", "", "", ""})
        GC.Add(New String() {"M*000172", "", "", "", ""})
        GC.Add(New String() {"M*000173", "", "", "", ""})
        GC.Add(New String() {"M*000174", "", "", "", ""})
        GC.Add(New String() {"M*000175", "", "", "", ""})
        GC.Add(New String() {"M*000176", "", "", "", ""})
        GC.Add(New String() {"M*000177", "", "", "", ""})
        GC.Add(New String() {"M*000178", "", "", "", ""})
        GC.Add(New String() {"M*000179", "", "", "", ""})
        GC.Add(New String() {"M*000180", "1", "1", "", C_RUN})
        GC.Add(New String() {"M*000181", "1", "1", "", C_ERR})
        GC.Add(New String() {"M*000182", "", "", "", ""})
        GC.Add(New String() {"M*000183", "1", "1", "", C_RECV})
        GC.Add(New String() {"M*000184", "", "", "", ""})
        GC.Add(New String() {"M*000185", "", "", "", ""})
        GC.Add(New String() {"M*000186", "", "", "", ""})
        GC.Add(New String() {"M*000187", "", "", "", ""})
        GC.Add(New String() {"M*000188", "", "", "", ""})
        GC.Add(New String() {"M*000189", "", "", "", ""})
        GC.Add(New String() {"M*000190", "", "", "", ""})
        GC.Add(New String() {"M*000191", "", "", "", ""})
        GC.Add(New String() {"M*000192", "", "", "", ""})
        GC.Add(New String() {"M*000193", "", "", "", ""})
        GC.Add(New String() {"M*000194", "", "", "", ""})
        GC.Add(New String() {"M*000195", "", "", "", ""})
        GC.Add(New String() {"M*000196", "", "", "", ""})
        GC.Add(New String() {"M*000197", "", "", "", ""})
        GC.Add(New String() {"M*000198", "", "", "", ""})
        GC.Add(New String() {"M*000199", "", "", "", ""})
        GC.Add(New String() {"M*000200", "", "", "", ""})
        GC.Add(New String() {"M*000201", "", "", "", ""})
        GC.Add(New String() {"M*000202", "", "", "", ""})
        GC.Add(New String() {"M*000203", "", "", "", ""})
        GC.Add(New String() {"M*000204", "", "", "", ""})
        GC.Add(New String() {"M*000205", "", "", "", ""})
        GC.Add(New String() {"M*000206", "", "", "", ""})
        GC.Add(New String() {"M*000207", "", "", "", ""})
        GC.Add(New String() {"M*000208", "", "", "", ""})
        GC.Add(New String() {"M*000209", "", "", "", ""})
        GC.Add(New String() {"M*000210", "", "", "", ""})
        GC.Add(New String() {"M*000211", "", "", "", ""})
        GC.Add(New String() {"M*000212", "", "", "", ""})
        GC.Add(New String() {"M*000213", "", "", "", ""})
        GC.Add(New String() {"M*000214", "", "", "", ""})
        GC.Add(New String() {"M*000215", "", "", "", ""})
        GC.Add(New String() {"M*000216", "", "", "", ""})
        GC.Add(New String() {"M*000217", "", "", "", ""})
        GC.Add(New String() {"M*000218", "", "", "", ""})
        GC.Add(New String() {"M*000219", "", "", "", ""})
        GC.Add(New String() {"M*000220", "", "", "", ""})
        GC.Add(New String() {"M*000221", "", "", "", ""})
        GC.Add(New String() {"M*000222", "", "", "", ""})
        GC.Add(New String() {"M*000223", "", "", "", ""})
        GC.Add(New String() {"M*000224", "", "", "", ""})
        GC.Add(New String() {"M*000225", "", "", "", ""})
        GC.Add(New String() {"M*000226", "", "", "", ""})
        GC.Add(New String() {"M*000227", "", "", "", ""})
        GC.Add(New String() {"M*000228", "", "", "", ""})
        GC.Add(New String() {"M*000229", "", "", "", ""})
        GC.Add(New String() {"M*000230", "", "", "", ""})
        GC.Add(New String() {"M*000231", "", "", "", ""})
        GC.Add(New String() {"M*000232", "", "", "", ""})
        GC.Add(New String() {"M*000233", "", "", "", ""})
        GC.Add(New String() {"M*000234", "", "", "", ""})
        GC.Add(New String() {"M*000235", "", "", "", ""})
        GC.Add(New String() {"M*000236", "", "", "", ""})
        GC.Add(New String() {"M*000237", "", "", "", ""})
        GC.Add(New String() {"M*000238", "", "", "", ""})
        GC.Add(New String() {"M*000239", "", "", "", ""})
        GC.Add(New String() {"M*000240", "", "", "", ""})
        GC.Add(New String() {"M*000241", "", "", "", ""})
        GC.Add(New String() {"M*000242", "", "", "", ""})
        GC.Add(New String() {"M*000243", "", "", "", ""})
        GC.Add(New String() {"M*000244", "", "", "", ""})
        GC.Add(New String() {"M*000245", "", "", "", ""})
        GC.Add(New String() {"M*000246", "", "", "", ""})
        GC.Add(New String() {"M*000247", "", "", "", ""})
        GC.Add(New String() {"M*000248", "", "", "", ""})
        GC.Add(New String() {"M*000249", "", "", "", ""})
        GC.Add(New String() {"M*000250", "", "", "", ""})
        GC.Add(New String() {"M*000251", "", "", "", ""})
        GC.Add(New String() {"M*000252", "", "", "", ""})
        GC.Add(New String() {"M*000253", "", "", "", ""})
        GC.Add(New String() {"M*000254", "", "", "", ""})
        GC.Add(New String() {"M*000255", "", "", "", ""})
        GC.Add(New String() {"M*000256", "", "", "", ""})
        GC.Add(New String() {"M*000257", "", "", "", ""})
        GC.Add(New String() {"M*000258", "", "", "", ""})
        GC.Add(New String() {"M*000259", "", "", "", ""})
        GC.Add(New String() {"M*000260", "", "", "", ""})
        GC.Add(New String() {"M*000261", "", "", "", ""})
        GC.Add(New String() {"M*000262", "", "", "", ""})
        GC.Add(New String() {"M*000263", "", "", "", ""})
        GC.Add(New String() {"M*000264", "", "", "", ""})
        GC.Add(New String() {"M*000265", "", "", "", ""})
        GC.Add(New String() {"M*000266", "", "", "", ""})
        GC.Add(New String() {"M*000267", "", "", "", ""})
        GC.Add(New String() {"M*000268", "", "", "", ""})
        GC.Add(New String() {"M*000269", "", "", "", ""})
        GC.Add(New String() {"M*000270", "", "", "", ""})
        GC.Add(New String() {"M*000271", "", "", "", ""})
        GC.Add(New String() {"M*000272", "", "", "", ""})
        GC.Add(New String() {"M*000273", "", "", "", ""})
        GC.Add(New String() {"M*000274", "", "", "", ""})
        GC.Add(New String() {"M*000275", "", "", "", ""})
        GC.Add(New String() {"M*000276", "", "", "", ""})
        GC.Add(New String() {"M*000277", "", "", "", ""})
        GC.Add(New String() {"M*000278", "", "", "", ""})
        GC.Add(New String() {"M*000279", "", "", "", ""})
        GC.Add(New String() {"M*000280", "", "", "", ""})
        GC.Add(New String() {"M*000281", "", "", "", ""})
        GC.Add(New String() {"M*000282", "", "", "", ""})
        GC.Add(New String() {"M*000283", "", "", "", ""})
        GC.Add(New String() {"M*000284", "", "", "", ""})
        GC.Add(New String() {"M*000285", "", "", "", ""})
        GC.Add(New String() {"M*000286", "", "", "", ""})
        GC.Add(New String() {"M*000287", "", "", "", ""})
        GC.Add(New String() {"M*000288", "", "", "", ""})
        GC.Add(New String() {"M*000289", "", "", "", ""})
        GC.Add(New String() {"M*000290", "", "", "", ""})
        GC.Add(New String() {"M*000291", "", "", "", ""})
        GC.Add(New String() {"M*000292", "", "", "", ""})
        GC.Add(New String() {"M*000293", "", "", "", ""})
        GC.Add(New String() {"M*000294", "", "", "", ""})
        GC.Add(New String() {"M*000295", "", "", "", ""})
        GC.Add(New String() {"M*000296", "", "", "", ""})
        GC.Add(New String() {"M*000297", "", "", "", ""})
        GC.Add(New String() {"M*000298", "", "", "", ""})
        GC.Add(New String() {"M*000299", "", "", "", ""})
        GC.Add(New String() {"M*000300", "", "", "", ""})
        GC.Add(New String() {"M*000301", "", "", "", ""})
        GC.Add(New String() {"M*000302", "", "", "", ""})
        GC.Add(New String() {"M*000303", "", "", "", ""})
        GC.Add(New String() {"M*000304", "", "", "", ""})
        GC.Add(New String() {"M*000305", "", "", "", ""})
        GC.Add(New String() {"M*000306", "", "", "", ""})
        GC.Add(New String() {"M*000307", "", "", "", ""})
        GC.Add(New String() {"M*000308", "", "", "", ""})
        GC.Add(New String() {"M*000309", "", "", "", ""})
        GC.Add(New String() {"M*000310", "", "", "", ""})
        GC.Add(New String() {"M*000311", "", "", "", ""})
        GC.Add(New String() {"M*000312", "", "", "", ""})
        GC.Add(New String() {"M*000313", "", "", "", ""})
        GC.Add(New String() {"M*000314", "", "", "", ""})
        GC.Add(New String() {"M*000315", "", "", "", ""})
        GC.Add(New String() {"M*000316", "", "", "", ""})
        GC.Add(New String() {"M*000317", "", "", "", ""})
        GC.Add(New String() {"M*000318", "", "", "", ""})
        GC.Add(New String() {"M*000319", "", "", "", ""})
        GC.Add(New String() {"M*000320", "", "", "", ""})
        GC.Add(New String() {"M*000321", "", "", "", ""})
        GC.Add(New String() {"M*000322", "", "", "", ""})
        GC.Add(New String() {"M*000323", "", "", "", ""})
        GC.Add(New String() {"M*000324", "", "", "", ""})
        GC.Add(New String() {"M*000325", "", "", "", ""})
        GC.Add(New String() {"M*000326", "", "", "", ""})
        GC.Add(New String() {"M*000327", "", "", "", ""})
        GC.Add(New String() {"M*000328", "", "", "", ""})
        GC.Add(New String() {"M*000329", "", "", "", ""})
        GC.Add(New String() {"M*000330", "", "", "", ""})
        GC.Add(New String() {"M*000331", "", "", "", ""})
        GC.Add(New String() {"M*000332", "", "", "", ""})
        GC.Add(New String() {"M*000333", "", "", "", ""})
        GC.Add(New String() {"M*000334", "", "", "", ""})
        GC.Add(New String() {"M*000335", "", "", "", ""})
        GC.Add(New String() {"M*000336", "", "", "", ""})
        GC.Add(New String() {"M*000337", "", "", "", ""})
        GC.Add(New String() {"M*000338", "", "", "", ""})
        GC.Add(New String() {"M*000339", "", "", "", ""})
        GC.Add(New String() {"M*000340", "", "", "", ""})
        GC.Add(New String() {"M*000341", "", "", "", ""})
        GC.Add(New String() {"M*000342", "", "", "", ""})
        GC.Add(New String() {"M*000343", "", "", "", ""})
        GC.Add(New String() {"M*000344", "", "", "", ""})
        GC.Add(New String() {"M*000345", "", "", "", ""})
        GC.Add(New String() {"M*000346", "", "", "", ""})
        GC.Add(New String() {"M*000347", "", "", "", ""})
        GC.Add(New String() {"M*000348", "", "", "", ""})
        GC.Add(New String() {"M*000349", "", "", "", ""})
        GC.Add(New String() {"M*000350", "", "", "", ""})
        GC.Add(New String() {"M*000351", "", "", "", ""})
        GC.Add(New String() {"M*000352", "", "", "", ""})
        GC.Add(New String() {"M*000353", "", "", "", ""})
        GC.Add(New String() {"M*000354", "", "", "", ""})
        GC.Add(New String() {"M*000355", "", "", "", ""})

    End Sub

End Class
