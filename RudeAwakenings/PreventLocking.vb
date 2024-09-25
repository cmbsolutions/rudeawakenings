Imports System.Runtime.InteropServices

Public Class PreventLocking
    ' Import the SetThreadExecutionState function from kernel32.dll
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function SetThreadExecutionState(esFlags As EXECUTION_STATE) As EXECUTION_STATE
    End Function

    ' Define the EXECUTION_STATE flags
    <Flags>
    Private Enum EXECUTION_STATE As UInteger
        ES_SYSTEM_REQUIRED = &H1
        ES_DISPLAY_REQUIRED = &H2
        ES_CONTINUOUS = &H80000000UI
    End Enum

    ' Function to prevent Windows from locking
    Public Sub StartPreventWindowsLocking()
        ' SetThreadExecutionState to prevent system and display from turning off
        SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_DISPLAY_REQUIRED Or EXECUTION_STATE.ES_CONTINUOUS)
    End Sub

    Public Sub StopPreventingWindowsLocking()
        ' Restore the normal behavior (allow system to sleep and display to turn off)
        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
    End Sub
End Class
