//- (INFO) 11/30 21:23:38,171
���ʼ������̡߳��ʼ������߳������ɹ���
//- (INFO) 11/30 21:23:38,171
���Զ�ɾ���̡߳��ʼ�ɾ���߳������ɹ���
//- (INFO) 11/30 21:23:38,210
���ʼ������̡߳��ʼ���ʼ����ʼ��
//- (INFO) 11/30 21:23:40,687
���ʼ������̡߳��ʼ���ʼ�����
//- (INFO) 11/30 21:23:42,828
���Զ�ɾ���̡߳����ҳ�7866���ɾ���ʼ�
//- (INFO) 11/30 21:23:45,000
���Զ�ɾ���̡߳����Զ�ɾ��5���ʼ�
//- (INFO) 11/30 21:28:45,409
���Զ�ɾ���̡߳����Զ�ɾ��5���ʼ�
//- (INFO) 11/30 21:33:45,974
���Զ�ɾ���̡߳����Զ�ɾ��5���ʼ�
//- (INFO) 11/30 22:00:32,970
���Զ�ɾ���̡߳��ʼ�ɾ���߳������ɹ���
//- (INFO) 11/30 22:00:32,970
���ʼ������̡߳��ʼ������߳������ɹ���
//- (INFO) 11/30 22:00:32,970
���ʼ������̡߳��ʼ���ʼ����ʼ��
//- (ERROR) 11/30 22:00:48,095
���Զ�ɾ���̡߳����ɾ���ʼ�����
System.Data.EntityException: �����ṩ������ Open ��ʧ�ܡ� ---> System.InvalidOperationException: ��ʱʱ���ѵ�����ʱʱ���ѵ���������δ�ӳ��л�ȡ���ӡ��������������������Ϊ���г����Ӿ���ʹ�ã����Ҵﵽ�����ش�С��
   �� System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   �� System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.Open()
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- �ڲ��쳣��ջ���ٵĽ�β ---
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   �� System.Data.EntityClient.EntityConnection.Open()
   �� System.Data.Objects.ObjectContext.EnsureConnection()
   �� System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   �� System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   �� WebMail2.Codes.MailDeleteThread.CheckDeleteMail() λ�� e:\8��̫����������\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:�к� 73
//- (INFO) 11/30 22:01:13,908
���ʼ������̡߳��ʼ������߳������ɹ���
//- (INFO) 11/30 22:01:13,908
���Զ�ɾ���̡߳��ʼ�ɾ���߳������ɹ���
//- (INFO) 11/30 22:01:13,924
���ʼ������̡߳��ʼ���ʼ����ʼ��
//- (ERROR) 11/30 22:01:29,018
���Զ�ɾ���̡߳����ɾ���ʼ�����
System.Data.EntityException: �����ṩ������ Open ��ʧ�ܡ� ---> System.InvalidOperationException: ��ʱʱ���ѵ�����ʱʱ���ѵ���������δ�ӳ��л�ȡ���ӡ��������������������Ϊ���г����Ӿ���ʹ�ã����Ҵﵽ�����ش�С��
   �� System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   �� System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.Open()
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- �ڲ��쳣��ջ���ٵĽ�β ---
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   �� System.Data.EntityClient.EntityConnection.Open()
   �� System.Data.Objects.ObjectContext.EnsureConnection()
   �� System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   �� System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   �� WebMail2.Codes.MailDeleteThread.CheckDeleteMail() λ�� e:\8��̫����������\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:�к� 73
//- (INFO) 11/30 22:01:46,456
���Զ�ɾ���̡߳��ʼ�ɾ���߳������ɹ���
//- (INFO) 11/30 22:01:46,456
���ʼ������̡߳��ʼ������߳������ɹ���
//- (INFO) 11/30 22:01:46,487
���ʼ������̡߳��ʼ���ʼ����ʼ��
//- (ERROR) 11/30 22:02:02,565
���Զ�ɾ���̡߳����ɾ���ʼ�����
System.Data.EntityException: �����ṩ������ Open ��ʧ�ܡ� ---> System.InvalidOperationException: ��ʱʱ���ѵ�����ʱʱ���ѵ���������δ�ӳ��л�ȡ���ӡ��������������������Ϊ���г����Ӿ���ʹ�ã����Ҵﵽ�����ش�С��
   �� System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   �� System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   �� System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   �� System.Data.SqlClient.SqlConnection.Open()
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   --- �ڲ��쳣��ջ���ٵĽ�β ---
   �� System.Data.EntityClient.EntityConnection.OpenStoreConnectionIf(Boolean openCondition, DbConnection storeConnectionToOpen, DbConnection originalConnection, String exceptionCode, String attemptedOperation, Boolean& closeStoreConnectionOnFailure)
   �� System.Data.EntityClient.EntityConnection.Open()
   �� System.Data.Objects.ObjectContext.EnsureConnection()
   �� System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   �� System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   �� WebMail2.Codes.MailDeleteThread.CheckDeleteMail() λ�� e:\8��̫����������\WebMail2_sql2005\WebMail2\Codes\MailDeleteThread.cs:�к� 73
//- (INFO) 11/30 22:04:35,646
���ʼ������̡߳��ʼ������߳������ɹ���
//- (INFO) 11/30 22:04:35,646
���Զ�ɾ���̡߳��ʼ�ɾ���߳������ɹ���
//- (INFO) 11/30 22:04:35,661
���ʼ������̡߳��ʼ���ʼ����ʼ��
//- (INFO) 11/30 22:04:35,927
���ʼ������̡߳��ʼ���ʼ�����
//- (INFO) 11/30 22:04:35,927
���Զ�ɾ���̡߳����ҳ�7851���ɾ���ʼ�
//- (INFO) 11/30 22:04:36,161
���Զ�ɾ���̡߳����Զ�ɾ��5���ʼ�
