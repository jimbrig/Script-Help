﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property TSQL_TEXT() As Integer
        Get
            Return CType(Me("TSQL_TEXT"),Integer)
        End Get
        Set
            Me("TSQL_TEXT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("'")>  _
    Public Property TSQL_QUOTE() As String
        Get
            Return CType(Me("TSQL_QUOTE"),String)
        End Get
        Set
            Me("TSQL_QUOTE") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
    Public Property TSQL_NUMERIC() As Integer
        Get
            Return CType(Me("TSQL_NUMERIC"),Integer)
        End Get
        Set
            Me("TSQL_NUMERIC") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("NULL")>  _
    Public Property TSQL_NULL() As String
        Get
            Return CType(Me("TSQL_NULL"),String)
        End Get
        Set
            Me("TSQL_NULL") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("mm:ss.0")>  _
    Public Property TSQL_DATE_PASTE_FORMAT() As String
        Get
            Return CType(Me("TSQL_DATE_PASTE_FORMAT"),String)
        End Get
        Set
            Me("TSQL_DATE_PASTE_FORMAT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("dd-mmm-yyyy")>  _
    Public Property TSQL_DATE_FORMAT() As String
        Get
            Return CType(Me("TSQL_DATE_FORMAT"),String)
        End Get
        Set
            Me("TSQL_DATE_FORMAT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
    Public Property TSQL_DATE() As Integer
        Get
            Return CType(Me("TSQL_DATE"),Integer)
        End Get
        Set
            Me("TSQL_DATE") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("SQL")>  _
    Public Property SQL_COL_NAME() As String
        Get
            Return CType(Me("SQL_COL_NAME"),String)
        End Get
        Set
            Me("SQL_COL_NAME") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("SkyBlue")>  _
    Public Property CLEAN_CELL_COLOUR() As Global.System.Drawing.Color
        Get
            Return CType(Me("CLEAN_CELL_COLOUR"),Global.System.Drawing.Color)
        End Get
        Set
            Me("CLEAN_CELL_COLOUR") = value
        End Set
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Anthony Duguid")>  _
    Public ReadOnly Property Author() As String
        Get
            Return CType(Me("Author"),String)
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("INSERT")>  _
    Public Property TSQL_QUERY_TYPE() As String
        Get
            Return CType(Me("TSQL_QUERY_TYPE"),String)
        End Get
        Set
            Me("TSQL_QUERY_TYPE") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\Temp")>  _
    Public Property HelpFile() As String
        Get
            Return CType(Me("HelpFile"),String)
        End Get
        Set
            Me("HelpFile") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_btnForceColumnToDate() As Boolean
        Get
            Return CType(Me("Visible_btnForceColumnToDate"),Boolean)
        End Get
        Set
            Me("Visible_btnForceColumnToDate") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_drpQueryType() As Boolean
        Get
            Return CType(Me("Visible_drpQueryType"),Boolean)
        End Get
        Set
            Me("Visible_drpQueryType") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_ComAddInsDialog() As Boolean
        Get
            Return CType(Me("Visible_ComAddInsDialog"),Boolean)
        End Get
        Set
            Me("Visible_ComAddInsDialog") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property Visible_FormatAsTableGallery() As Boolean
        Get
            Return CType(Me("Visible_FormatAsTableGallery"),Boolean)
        End Get
        Set
            Me("Visible_FormatAsTableGallery") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_ViewFreezePanesGallery() As Boolean
        Get
            Return CType(Me("Visible_ViewFreezePanesGallery"),Boolean)
        End Get
        Set
            Me("Visible_ViewFreezePanesGallery") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_RemoveDuplicates() As Boolean
        Get
            Return CType(Me("Visible_RemoveDuplicates"),Boolean)
        End Get
        Set
            Me("Visible_RemoveDuplicates") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property Visible_btnCompareWorksheets() As Boolean
        Get
            Return CType(Me("Visible_btnCompareWorksheets"),Boolean)
        End Get
        Set
            Me("Visible_btnCompareWorksheets") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty

        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>
        Friend ReadOnly Property Settings() As Global.ScriptHelp.MySettings
            Get
                Return Global.ScriptHelp.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
