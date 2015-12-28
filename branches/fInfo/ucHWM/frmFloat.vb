﻿'/*

'  ucHWM Floating form class
'  Version: MPL 1.1/GPL 2.0/LGPL 2.1

'  The contents of this file are subject to the Mozilla Public License Version
'  1.1 (the "License"); you may not use this file except in compliance with
'  the License. You may obtain a copy of the License at

'  http://www.mozilla.org/MPL/

'  Software distributed under the License is distributed on an "AS IS" basis,
'  WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
'  for the specific language governing rights and limitations under the License.

'  The Original Code is the cftUnity.nl source code.

'  The Initial Developer of the Original Code is 
'   Marvin Westmaas/ Marvin_The_Martian / MtM ( webmaster@cftunity.nl )
'  Portions created by the Initial Developer are Copyright (C) 2010-2011
'  the Initial Developer. All Rights Reserved.

'  The repository for cftUnity.nl is hosted at
'  http://code.google.com/p/cftunity/

'  Contributor(s):

'  Alternatively, the contents of this file may be used under the terms of
'  either the GNU General Public License Version 2 or later (the "GPL"), or
'  the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
'  in which case the provisions of the GPL or the LGPL are applicable instead
'  of those above. If you wish to allow use of your version of this file only
'  under the terms of either the GPL or the LGPL, and not to allow others to
'  use your version of this file under the terms of the MPL, indicate your
'  decision by deleting the provisions above and replace them with the notice
'  and other provisions required by the GPL or the LGPL. If you do not delete
'  the provisions above, a recipient may use your version of this file under
'  the terms of any one of the MPL, the GPL or the LGPL.

'*/
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmFloat
    Public Shadows Event Closed()
    Private Sub frmFloat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent Closed()
    End Sub

    Private Sub frmFloat_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            Static bOnce As Boolean = False
            If Not bOnce Then
                bOnce = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmFloat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class