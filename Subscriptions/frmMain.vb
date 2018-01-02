Imports Microsoft.Win32.TaskScheduler
Imports Serilog

Public Class frmMain
    Dim log As ILogger = SubscriptionInfo.Info.getLogger
    Private Sub btnSubscribe_Click(sender As Object, e As EventArgs) Handles btnSubscribe.Click

        SetupScheduledTask(GenerateSubscription().AddMinutes(1))
        'Wait a minute and watch the "subscription details" file get deleted by the scheduled task.  
    End Sub

    Function GenerateSubscription() As Date
        Dim dt As Date = Now
        log.Information($"Bought a subscription at {dt:G}.")
        My.Computer.FileSystem.WriteAllText(SubscriptionInfo.Info.SubscriptionFile, $"{dt:G}", False)
        Process.Start("explorer.exe", $"/select, ""{SubscriptionInfo.Info.SubscriptionFile}""")

        Return dt
    End Function

    Sub SetupScheduledTask(EndDate As Date)
        Using ts As TaskService = TaskService.Instance



            Dim tsk As Task = ts.
                Execute(IO.Path.Combine(My.Application.Info.DirectoryPath, "EndSubscription.exe")).InWorkingDirectory(My.Application.Info.DirectoryPath).
                Once().Starting(EndDate).
                Ending(EndDate.AddMinutes(5)).
                AsTask("Test Subscription")
            With tsk
                With .Definition
                    With .Settings
                        .DeleteExpiredTaskAfter() = TimeSpan.FromMinutes(30)
                        .StartWhenAvailable = True
                        .WakeToRun = True
                        .Compatibility = TaskCompatibility.V2_3
                        .Enabled = True
                        .DisallowStartIfOnBatteries = False
                        .AllowHardTerminate = True
                        .ExecutionTimeLimit = TimeSpan.FromSeconds(30)
                    End With

                End With
                tsk.RegisterChanges()
                'Dim dlg As New TaskEditDialog(tsk, False, False)
                'dlg.ShowDialog()
            End With




        End Using

    End Sub
End Class
