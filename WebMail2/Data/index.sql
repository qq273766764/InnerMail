USE mail
go
CREATE NONCLUSTERED INDEX [_dta_index_Attachments_7_2073058421__K2_1_3_4_5_6] ON [dbo].[Attachments] 
(
	[MailId] ASC
)
INCLUDE ( [ID],
[FileName],
[FilePath],
[FileSize],
[FileId]) WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [_dta_index_MailInfo_7_245575913__K9_K4_K1] ON [dbo].[MailInfo] 
(
	[IsDraft] ASC,
	[SendFromId] ASC,
	[ID] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [_dta_index_MailState_7_277576027__K4_K5_K9_K11_K7_K1_K2] ON [dbo].[MailState] 
(
	[Uid] ASC,
	[IsRead] ASC,
	[IsDustbinInbox] ASC,
	[IsDustbinOutbox] ASC,
	[IsDel] ASC,
	[ID] ASC,
	[MailId] ASC
)WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [_dta_index_MailState_7_277576027__K7_K2_K11_K4_K9_1_3_5_6_8_10_12] ON [dbo].[MailState] 
(
	[IsDel] ASC,
	[MailId] ASC,
	[IsDustbinOutbox] ASC,
	[Uid] ASC,
	[IsDustbinInbox] ASC
)
INCLUDE ( [ID],
[UName],
[IsRead],
[ReadTime],
[DelTime],
[DustbinTimeInbox],
[DustbinTimeOutbox]) WITH (SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
GO

