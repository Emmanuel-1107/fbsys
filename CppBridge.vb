Imports System.Runtime.InteropServices

Module CppBridge

    ' --------------------------------------------------------
    '  FORM 2 — Student Feedback
    ' --------------------------------------------------------

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function SubmitFeedback(
    username As String,
    subjectCode As String,
    instructor As String,
    semester As String,
    subjectRating As Integer,
    instructorRating As Integer,
    comments As String,
    ipHash As String) As Boolean
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetSubjects() As IntPtr
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetInstructorsBySubject(subjectCode As String) As IntPtr
    End Function

    ' --------------------------------------------------------
    '  FORM 3 — Admin Login
    ' --------------------------------------------------------

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function AdminLogin(
        username As String,
        password As String) As Boolean
    End Function

    ' --------------------------------------------------------
    '  FORM 4 — Admin Dashboard
    ' --------------------------------------------------------

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetAllFeedback() As IntPtr
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetFilteredFeedback(
        semester As String,
        subjectCode As String,
        instructor As String) As IntPtr
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetAverageSubjectRating(subjectCode As String) As Double
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetAverageInstructorRating(instructor As String) As Double
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function GetTotalResponses() As Integer
    End Function

    <DllImport("FeedbackSystemTUGN.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Function ExportCSV(filepath As String) As Boolean
    End Function

    ' --------------------------------------------------------
    '  Helper — converts IntPtr returned from C++ to VB String
    ' --------------------------------------------------------
    Public Function PtrToString(ptr As IntPtr) As String
        Return Marshal.PtrToStringAnsi(ptr)
    End Function

End Module
