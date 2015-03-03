//- (INFO) 11/30 21:23:38,171
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/30 21:23:38,171
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/30 21:23:38,210
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/30 21:23:40,687
【邮件发送线程】邮件初始化完成
//- (INFO) 11/30 21:23:42,828
【自动删除线程】已找出7866封待删除邮件
//- (INFO) 11/30 21:23:45,000
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/30 21:28:45,409
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/30 21:33:45,974
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/30 22:00:32,970
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/30 22:00:32,970
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/30 22:00:32,970
【邮件发送线程】邮件初始化开始…
//- (ERROR) 11/30 22:00:48,095
【自动删除线程】检查删除邮件出错！
System.Data.EntityException: 基础提供程序在 Open 上失败。 ---> System.InvalidOperationException: 超时时间已到。超时时间已到，但是尚未从池中获取连接。出现这种情况可能是因为所有池连接均在使用，并且达到了最大池大小。
   在 System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   在 System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.Open()
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- 内部异常堆栈跟踪的结尾 ---
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   在 System.Data.EntityClient.EntityConnection.Open()
   在 System.Data.Objects.ObjectContext.EnsureConnection()
   在 System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   在 System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   在 WebMail2.Codes.MailDeleteThread.CheckDeleteMail() 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:行号 73
//- (INFO) 11/30 22:01:13,908
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/30 22:01:13,908
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/30 22:01:13,924
【邮件发送线程】邮件初始化开始…
//- (ERROR) 11/30 22:01:29,018
【自动删除线程】检查删除邮件出错！
System.Data.EntityException: 基础提供程序在 Open 上失败。 ---> System.InvalidOperationException: 超时时间已到。超时时间已到，但是尚未从池中获取连接。出现这种情况可能是因为所有池连接均在使用，并且达到了最大池大小。
   在 System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   在 System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.Open()
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- 内部异常堆栈跟踪的结尾 ---
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   在 System.Data.EntityClient.EntityConnection.Open()
   在 System.Data.Objects.ObjectContext.EnsureConnection()
   在 System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   在 System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   在 WebMail2.Codes.MailDeleteThread.CheckDeleteMail() 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:行号 73
//- (INFO) 11/30 22:01:46,456
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/30 22:01:46,456
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/30 22:01:46,487
【邮件发送线程】邮件初始化开始…
//- (ERROR) 11/30 22:02:02,565
【自动删除线程】检查删除邮件出错！
System.Data.EntityException: 基础提供程序在 Open 上失败。 ---> System.InvalidOperationException: 超时时间已到。超时时间已到，但是尚未从池中获取连接。出现这种情况可能是因为所有池连接均在使用，并且达到了最大池大小。
   在 System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   在 System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   在 System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   在 System.Data.SqlClient.SqlConnection.Open()
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- 内部异常堆栈跟踪的结尾 ---
   在 System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   在 System.Data.EntityClient.EntityConnection.Open()
   在 System.Data.Objects.ObjectContext.EnsureConnection()
   在 System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   在 System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   在 WebMail2.Codes.MailDeleteThread.CheckDeleteMail() 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:行号 73
//- (INFO) 11/30 22:04:35,646
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/30 22:04:35,646
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/30 22:04:35,661
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/30 22:04:35,927
【邮件发送线程】邮件初始化完成
//- (INFO) 11/30 22:04:35,927
【自动删除线程】已找出7851封待删除邮件
//- (INFO) 11/30 22:04:36,161
【自动删除线程】已自动删除5封邮件
