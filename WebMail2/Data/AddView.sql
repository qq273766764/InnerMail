use mail
go
create view View_AllMail_NoGUID
as 
SELECT     dbo.MailState.ID AS mid, dbo.MailState.MailId, dbo.MailInfo.[Level], dbo.MailInfo.SendFromName, dbo.MailInfo.SendFromId, dbo.MailInfo.ID, dbo.MailInfo.AddresseeIds, dbo.MailInfo.Subject, 
                      dbo.MailInfo.SendTime, dbo.MailInfo.IsDraft, dbo.MailInfo.AddresseeNames, dbo.MailState.UName, dbo.MailState.Uid, dbo.MailState.IsRead, dbo.MailState.ReadTime, dbo.MailState.IsDel, 
                      dbo.MailState.ID AS StateID, dbo.MailState.DelTime, dbo.MailState.IsDustbinInbox, dbo.MailState.DustbinTimeInbox, dbo.MailState.IsDustbinOutbox, dbo.MailState.DustbinTimeOutbox
FROM         dbo.MailInfo WITH (nolock) LEFT OUTER JOIN
                      dbo.MailState WITH (nolock) ON dbo.MailInfo.ID = dbo.MailState.MailId
go