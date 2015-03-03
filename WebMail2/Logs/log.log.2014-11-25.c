//- (INFO) 11/25 09:04:29,557
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:04:29,557
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:04:29,572
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:04:29,947
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:04:30,369
【自动删除线程】已找出8846封待删除邮件
//- (INFO) 11/25 09:04:30,838
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 09:06:35,169
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:06:35,169
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:06:35,185
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:06:35,310
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:06:35,841
【自动删除线程】已找出8841封待删除邮件
//- (INFO) 11/25 09:06:36,044
【自动删除线程】已自动删除5封邮件
//- (ERROR) 11/25 09:06:51,505
【邮件列表】加载邮件数据出错
System.InvalidOperationException: “View_ALLMail”的“mid”属性不能设置为“Decimal”值。必须将该属性设置为类型为“Guid”的非 null 值。
   在 System.Data.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader`1.GetValue(DbDataReader reader, Int32 ordinal)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Shaper.HandleEntityAppendOnly[TEntity](Func`2 constructEntityDelegate, EntityKey entityKey, EntitySet entitySet)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Coordinator`1.ReadNextElement(Shaper shaper)
   在 System.Data.Common.Internal.Materialization.Shaper`1.SimpleEnumerator.MoveNext()
   在 System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   在 System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   在 WebMail2.Codes.DataProvider.QueryReciveMailBox(String uid, String key, Int32 pageindex, Int32 pagesize, Int32& count) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\DataProvider.cs:行号 109
   在 WebMail2.Server.DataServer.ProcessRequest(HttpContext context) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Server\DataServer.ashx.cs:行号 31
//- (ERROR) 11/25 09:06:54,927
【邮件列表】加载邮件数据出错
System.InvalidOperationException: “View_ALLMail”的“mid”属性不能设置为“Decimal”值。必须将该属性设置为类型为“Guid”的非 null 值。
   在 System.Data.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader`1.GetValue(DbDataReader reader, Int32 ordinal)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Shaper.HandleEntityAppendOnly[TEntity](Func`2 constructEntityDelegate, EntityKey entityKey, EntitySet entitySet)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Coordinator`1.ReadNextElement(Shaper shaper)
   在 System.Data.Common.Internal.Materialization.Shaper`1.SimpleEnumerator.MoveNext()
   在 System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   在 System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   在 WebMail2.Codes.DataProvider.QuerySendMailBox(String uid, Boolean IsDraft, String key, Int32 pageindex, Int32 pagesize, Int32& Count) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\DataProvider.cs:行号 87
   在 WebMail2.Server.DataServer.ProcessRequest(HttpContext context) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Server\DataServer.ashx.cs:行号 35
//- (ERROR) 11/25 09:06:55,894
【邮件列表】加载邮件数据出错
System.InvalidOperationException: “View_ALLMail”的“mid”属性不能设置为“Decimal”值。必须将该属性设置为类型为“Guid”的非 null 值。
   在 System.Data.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader`1.GetValue(DbDataReader reader, Int32 ordinal)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Shaper.HandleEntityAppendOnly[TEntity](Func`2 constructEntityDelegate, EntityKey entityKey, EntitySet entitySet)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Coordinator`1.ReadNextElement(Shaper shaper)
   在 System.Data.Common.Internal.Materialization.Shaper`1.SimpleEnumerator.MoveNext()
   在 System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   在 System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   在 WebMail2.Codes.DataProvider.QueryReciveMailBox(String uid, String key, Int32 pageindex, Int32 pagesize, Int32& count) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\DataProvider.cs:行号 109
   在 WebMail2.Server.DataServer.ProcessRequest(HttpContext context) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Server\DataServer.ashx.cs:行号 31
//- (INFO) 11/25 09:08:36,093
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:08:36,093
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:08:36,108
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:08:36,280
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:08:36,312
【自动删除线程】已找出8836封待删除邮件
//- (INFO) 11/25 09:08:36,452
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 09:10:14,648
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:10:14,648
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:10:14,664
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:10:14,804
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:10:14,820
【自动删除线程】已找出8831封待删除邮件
//- (INFO) 11/25 09:10:14,976
【自动删除线程】已自动删除5封邮件
//- (ERROR) 11/25 09:10:26,336
【邮件列表】加载邮件数据出错
System.InvalidOperationException: “View_ALLMail”的“mid”属性不能设置为“Decimal”值。必须将该属性设置为类型为“Guid”的非 null 值。
   在 System.Data.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader`1.GetValue(DbDataReader reader, Int32 ordinal)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Shaper.HandleEntityAppendOnly[TEntity](Func`2 constructEntityDelegate, EntityKey entityKey, EntitySet entitySet)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Coordinator`1.ReadNextElement(Shaper shaper)
   在 System.Data.Common.Internal.Materialization.Shaper`1.SimpleEnumerator.MoveNext()
   在 System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   在 System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   在 WebMail2.Codes.DataProvider.QueryReciveMailBox(String uid, String key, Int32 pageindex, Int32 pagesize, Int32& count) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\DataProvider.cs:行号 109
   在 WebMail2.Server.DataServer.ProcessRequest(HttpContext context) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Server\DataServer.ashx.cs:行号 31
//- (ERROR) 11/25 09:10:27,894
【邮件列表】加载邮件数据出错
System.InvalidOperationException: “View_ALLMail”的“mid”属性不能设置为“Decimal”值。必须将该属性设置为类型为“Guid”的非 null 值。
   在 System.Data.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader`1.GetValue(DbDataReader reader, Int32 ordinal)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Shaper.HandleEntityAppendOnly[TEntity](Func`2 constructEntityDelegate, EntityKey entityKey, EntitySet entitySet)
   在 lambda_method(Closure , Shaper )
   在 System.Data.Common.Internal.Materialization.Coordinator`1.ReadNextElement(Shaper shaper)
   在 System.Data.Common.Internal.Materialization.Shaper`1.SimpleEnumerator.MoveNext()
   在 System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   在 System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   在 WebMail2.Codes.DataProvider.QuerySendMailBox(String uid, Boolean IsDraft, String key, Int32 pageindex, Int32 pagesize, Int32& Count) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Codes\DataProvider.cs:行号 87
   在 WebMail2.Server.DataServer.ProcessRequest(HttpContext context) 位置 e:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Server\DataServer.ashx.cs:行号 35
//- (INFO) 11/25 09:15:17,987
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:15:17,987
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:15:18,002
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:15:18,440
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:15:18,846
【自动删除线程】已找出8826封待删除邮件
//- (INFO) 11/25 09:15:19,263
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 09:51:38,717
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:51:38,717
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:51:38,717
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:51:38,951
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:51:40,123
【自动删除线程】已找出8821封待删除邮件
//- (INFO) 11/25 09:51:40,446
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 09:55:11,705
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 09:55:11,705
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 09:55:11,736
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 09:55:11,845
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 09:55:12,158
【自动删除线程】已找出8816封待删除邮件
//- (INFO) 11/25 09:55:12,908
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:00:50,732
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:00:50,732
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:00:50,748
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:00:50,920
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:00:50,998
【自动删除线程】已找出8811封待删除邮件
//- (INFO) 11/25 10:00:51,279
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:18:46,016
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:18:46,016
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:18:46,016
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:18:46,141
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:18:46,234
【自动删除线程】已找出8806封待删除邮件
//- (INFO) 11/25 10:18:46,453
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:23:57,227
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:23:57,227
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:23:57,243
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:23:57,368
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:23:57,368
【自动删除线程】已找出8801封待删除邮件
//- (INFO) 11/25 10:23:57,508
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:24:43,566
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:24:43,566
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:24:43,582
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:24:44,769
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:24:44,769
【自动删除线程】已找出8796封待删除邮件
//- (INFO) 11/25 10:24:45,082
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:27:00,093
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:27:00,093
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:27:00,109
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:27:00,249
【自动删除线程】已找出8791封待删除邮件
//- (INFO) 11/25 10:27:00,249
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:27:00,374
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:30:50,205
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:30:50,205
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:30:50,220
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:30:50,361
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:30:50,377
【自动删除线程】已找出8786封待删除邮件
//- (INFO) 11/25 10:30:50,486
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:31:47,596
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:31:47,596
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:31:47,612
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:31:47,737
【自动删除线程】已找出8781封待删除邮件
//- (INFO) 11/25 10:31:47,737
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:31:47,846
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:54:13,307
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:54:13,307
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:54:13,322
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:54:13,447
【自动删除线程】已找出8776封待删除邮件
//- (INFO) 11/25 10:54:13,447
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:54:13,572
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:57:05,806
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:57:05,806
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:57:05,806
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:57:11,259
【自动删除线程】已找出8771封待删除邮件
//- (INFO) 11/25 10:57:11,353
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:57:11,606
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 10:58:30,641
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 10:58:30,641
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 10:58:30,657
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 10:58:30,891
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 10:58:30,891
【自动删除线程】已找出8766封待删除邮件
//- (INFO) 11/25 10:58:31,000
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:03:31,165
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:08:31,393
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:13:31,548
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:18:31,685
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:23:31,925
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:28:32,070
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:33:32,190
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:38:33,418
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:51:51,730
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 11:51:51,730
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 11:51:51,839
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 11:51:51,964
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 11:51:51,980
【自动删除线程】已找出8706封待删除邮件
//- (INFO) 11/25 11:51:52,214
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 11:55:42,478
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 11:55:42,478
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 11:55:42,572
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 11:55:42,759
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 11:55:42,759
【自动删除线程】已找出8701封待删除邮件
//- (INFO) 11/25 11:55:43,009
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:00:43,209
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:05:37,889
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 12:05:37,889
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 12:05:37,905
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 12:05:38,014
【自动删除线程】已找出8691封待删除邮件
//- (INFO) 11/25 12:05:38,014
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 12:05:38,155
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:10:38,297
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:15:39,445
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 12:15:39,445
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 12:15:39,602
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 12:15:40,024
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 12:15:40,039
【自动删除线程】已找出8681封待删除邮件
//- (INFO) 11/25 12:15:40,211
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:18:49,647
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 12:18:49,647
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 12:18:49,694
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 12:18:49,803
【自动删除线程】已找出8676封待删除邮件
//- (INFO) 11/25 12:18:49,819
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 12:18:49,913
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:20:06,842
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 12:20:06,842
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 12:20:06,889
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 12:20:06,999
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 12:20:07,014
【自动删除线程】已找出8671封待删除邮件
//- (INFO) 11/25 12:20:07,139
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:25:07,302
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:30:07,556
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:35:07,701
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:40:07,955
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:45:08,147
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 12:50:08,308
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 13:16:30,897
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 13:21:31,074
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 13:24:31,693
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 13:24:31,693
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 13:24:31,724
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 13:24:31,833
【自动删除线程】已找出8626封待删除邮件
//- (INFO) 11/25 13:24:31,833
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 13:24:32,037
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 13:29:32,275
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:03:06,968
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 14:03:06,968
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 14:03:07,155
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 14:03:14,168
【自动删除线程】已找出8616封待删除邮件
//- (INFO) 11/25 14:03:14,621
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 14:03:17,309
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:08:17,549
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:12:12,666
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 14:12:12,666
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 14:12:12,682
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 14:12:12,807
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 14:12:12,822
【自动删除线程】已找出8606封待删除邮件
//- (INFO) 11/25 14:12:13,104
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:16:29,650
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 14:16:29,650
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 14:16:29,666
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 14:16:29,775
【自动删除线程】已找出8601封待删除邮件
//- (INFO) 11/25 14:16:29,791
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 14:16:29,916
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:20:18,258
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 14:20:18,274
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 14:20:18,274
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 14:20:18,524
【自动删除线程】已找出8596封待删除邮件
//- (INFO) 11/25 14:20:18,539
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 14:20:18,758
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:25:18,776
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:30:19,634
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:35:19,688
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 14:40:19,777
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:15:21,731
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 15:15:21,746
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 15:15:21,825
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 15:15:22,106
【自动删除线程】已找出8551封待删除邮件
//- (INFO) 11/25 15:15:22,106
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 15:15:22,325
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:19:39,403
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 15:19:39,403
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 15:19:39,419
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 15:19:39,607
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 15:19:39,607
【自动删除线程】已找出8546封待删除邮件
//- (INFO) 11/25 15:19:39,763
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:27:14,394
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 15:27:14,394
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 15:27:14,441
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 15:27:14,598
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 15:27:14,613
【自动删除线程】已找出8541封待删除邮件
//- (INFO) 11/25 15:27:14,832
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:32:15,163
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:35:43,898
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 15:35:43,898
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 15:35:43,945
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 15:35:44,070
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 15:35:44,163
【自动删除线程】已找出8531封待删除邮件
//- (INFO) 11/25 15:35:44,429
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:40:44,733
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:45:45,162
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:49:37,483
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 15:49:37,483
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 15:49:37,498
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 15:49:37,863
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 15:49:38,131
【自动删除线程】已找出8516封待删除邮件
//- (INFO) 11/25 15:49:38,326
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:54:38,829
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 15:59:40,220
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 16:03:53,449
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 16:03:53,449
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 16:03:53,496
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 16:03:54,697
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 16:03:55,026
【自动删除线程】已找出8501封待删除邮件
//- (INFO) 11/25 16:03:55,366
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 16:08:55,683
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 16:11:26,155
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 16:11:26,155
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 16:11:26,195
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 16:11:26,306
【自动删除线程】已找出8491封待删除邮件
//- (INFO) 11/25 16:11:26,321
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 16:11:26,502
【自动删除线程】已自动删除5封邮件
//- (INFO) 11/25 16:15:44,893
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 11/25 16:15:44,894
【自动删除线程】邮件删除线程启动成功！
//- (INFO) 11/25 16:15:44,908
【邮件发送线程】邮件初始化开始…
//- (INFO) 11/25 16:15:45,034
【邮件发送线程】邮件初始化完成
//- (INFO) 11/25 16:15:45,057
【自动删除线程】已找出8486封待删除邮件
//- (INFO) 11/25 16:15:45,316
【自动删除线程】已自动删除5封邮件
