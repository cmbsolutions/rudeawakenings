Imports System.Runtime.InteropServices

Public Class PreventAwsWorkspacePopupMenu
    ' Import Windows API functions to get and set mouse cursor position
    <DllImport("user32.dll")>
    Private Shared Function GetCursorPos(ByRef lpPoint As POINT) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetCursorPos(x As Integer, y As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetKeyState(nVirtKey As Integer) As Short
    End Function

    ' Import necessary Windows API functions
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(idHook As Integer, lpfn As LowLevelMouseProc, hMod As IntPtr, dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function CallNextHookEx(hhk As IntPtr, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    ' Structure to hold the mouse coordinates
    <StructLayout(LayoutKind.Sequential)>
    Public Structure POINT
        Public X As Integer
        Public Y As Integer
    End Structure

    ' Define the structure for mouse hook information
    <StructLayout(LayoutKind.Sequential)>
    Public Structure MSLLHOOKSTRUCT
        Public pt As POINT
        Public mouseData As UInteger
        Public flags As UInteger
        Public time As UInteger
        Public dwExtraInfo As IntPtr
    End Structure

    ' Constants for mouse hook
    Private Const WH_MOUSE_LL As Integer = 14
    Private Const WM_MOUSEMOVE As Integer = &H200

    ' Virtual key code for the CTRL key
    Private Const VK_CONTROL As Integer = &H11

    ' Hook callback function delegate
    Private mouseHookDelegate As LowLevelMouseProc
    Private mouseHookHandle As IntPtr = IntPtr.Zero

    ' Low-level mouse hook procedure callback function type
    Private Delegate Function LowLevelMouseProc(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

    Public Property RestrictedAreaHeight As Integer = 4

    Public Sub StartListeningToMouse()
        If mouseHookHandle = IntPtr.Zero Then
            mouseHookDelegate = New LowLevelMouseProc(AddressOf MouseHookCallback)
            mouseHookHandle = SetWindowsHookEx(WH_MOUSE_LL, mouseHookDelegate, IntPtr.Zero, 0)
        End If
    End Sub

    Public Sub StopListeningToMouse()
        If mouseHookHandle <> IntPtr.Zero Then
            UnhookWindowsHookEx(mouseHookHandle)
        End If
    End Sub

    ' The callback function for the mouse hook
    Private Function MouseHookCallback(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = CType(WM_MOUSEMOVE, IntPtr) Then
            ' Get the mouse hook structure
            Dim mouseStruct As MSLLHOOKSTRUCT = Marshal.PtrToStructure(Of MSLLHOOKSTRUCT)(lParam)

            ' Check if the mouse is in the restricted area (first 2 rows of pixels)
            If mouseStruct.pt.Y < RestrictedAreaHeight Then
                ' Check if the CTRL key is pressed
                If (GetKeyState(VK_CONTROL) And &H8000) = 0 Then
                    ' Move the cursor just below the restricted area
                    Cursor.Position = New Drawing.Point(mouseStruct.pt.X, RestrictedAreaHeight)
                    ' Skip further processing of this mouse event
                    Return CType(1, IntPtr) ' Return 1 to block the event
                End If
            End If
        End If

        ' Call the next hook in the chain
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function
End Class
