//- (INFO) 01/29 19:22:45,770
----------------- 系统启动 -----------------
//- (INFO) 01/29 19:22:45,785
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 01/29 19:22:45,785
【自动删除线程】邮件删除线程启动成功，初始化开始！
//- (INFO) 01/29 19:22:45,785
【邮件发送线程】初始化开始…
//- (INFO) 01/29 19:22:46,801
【邮件发送线程】初始化完成，找出0封未发送成功邮件，耗时：1016ms
//- (INFO) 01/29 19:22:48,848
【自动删除线程】已找出0封待删除邮件，耗时：3031.2805ms
//- (INFO) 01/29 19:22:48,848
【自动删除线程】初始化完成！
//- (INFO) 01/29 19:25:56,038
----------------- 系统终止 -----------------
//- (INFO) 01/29 19:26:01,490
----------------- 系统启动 -----------------
//- (INFO) 01/29 19:26:01,505
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 01/29 19:26:01,505
【自动删除线程】邮件删除线程启动成功，初始化开始！
//- (INFO) 01/29 19:26:01,505
【邮件发送线程】初始化开始…
//- (INFO) 01/29 19:26:02,193
【自动删除线程】已找出0封待删除邮件，耗时：531.2468ms
//- (INFO) 01/29 19:26:02,193
【自动删除线程】初始化完成！
//- (INFO) 01/29 19:26:02,287
【邮件发送线程】初始化完成，找出0封未发送成功邮件，耗时：781ms
//- (INFO) 01/29 19:26:29,550
----------------- 系统启动 -----------------
//- (INFO) 01/29 19:26:29,581
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 01/29 19:26:29,581
【自动删除线程】邮件删除线程启动成功，初始化开始！
//- (INFO) 01/29 19:26:29,596
【邮件发送线程】初始化开始…
//- (INFO) 01/29 19:26:31,878
【自动删除线程】已找出0封待删除邮件，耗时：1187.4971ms
//- (INFO) 01/29 19:26:31,878
【自动删除线程】初始化完成！
//- (INFO) 01/29 19:26:31,972
【邮件发送线程】初始化完成，找出0封未发送成功邮件，耗时：2375ms
//- (INFO) 01/29 19:46:47,453
----------------- 系统终止 -----------------
//- (INFO) 01/29 19:46:51,843
----------------- 系统启动 -----------------
//- (INFO) 01/29 19:46:51,843
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 01/29 19:46:51,843
【自动删除线程】邮件删除线程启动成功，初始化开始！
//- (INFO) 01/29 19:46:51,859
【邮件发送线程】初始化开始…
//- (INFO) 01/29 19:46:51,984
【自动删除线程】已找出0封待删除邮件，耗时：93.7514ms
//- (INFO) 01/29 19:46:51,984
【自动删除线程】初始化完成！
//- (INFO) 01/29 19:46:51,984
【邮件发送线程】初始化完成，找出0封未发送成功邮件，耗时：125ms
//- (INFO) 01/29 20:08:57,936
----------------- 系统终止 -----------------
//- (INFO) 01/29 20:09:50,450
----------------- 系统启动 -----------------
//- (INFO) 01/29 20:09:50,450
【邮件发送线程】邮件发送线程启动成功！
//- (INFO) 01/29 20:09:50,450
【自动删除线程】邮件删除线程启动成功，初始化开始！
//- (INFO) 01/29 20:09:50,465
【邮件发送线程】初始化开始…
//- (INFO) 01/29 20:09:50,622
【邮件发送线程】初始化完成，找出0封未发送成功邮件，耗时：156ms
//- (INFO) 01/29 20:09:50,622
【自动删除线程】已找出0封待删除邮件，耗时：93.747ms
//- (INFO) 01/29 20:09:50,622
【自动删除线程】初始化完成！
//- (ERROR) 01/29 20:11:02,776
【发送邮件】发送邮件错误！
System.Exception: SWFUpload_0_0 不是 Int32 的有效值。 ---> System.FormatException: 输入字符串的格式不正确。
   在 System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   在 System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   在 System.ComponentModel.Int32Converter.FromString(String value, NumberFormatInfo formatInfo)
   在 System.ComponentModel.BaseNumberConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
   --- 内部异常堆栈跟踪的结尾 ---
   在 System.ComponentModel.BaseNumberConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.AssignToPropertyOrField(Object propertyValue, Object o, String memberName, JavaScriptSerializer serializer, Boolean throwOnError)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertDictionaryToObject(IDictionary`2 dictionary, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.AddItemToList(IList oldList, IList newList, Type elementType, JavaScriptSerializer serializer, Boolean throwOnError)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertListToObject(IList list, Type type, JavaScriptSerializer serializer, Boolean throwOnError, IList& convertedList)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.JavaScriptSerializer.Deserialize(JavaScriptSerializer serializer, String input, Type type, Int32 depthLimit)
   在 System.Web.Script.Serialization.JavaScriptSerializer.Deserialize[T](String input)
   在 WebMail2.Ctrs.Uploadify.GetFiles() 位置 f:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Ctrs\Uploadify.ascx.cs:行号 26
   在 WebMail2.SendMail.SaveEmail(Boolean isDraft) 位置 f:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\SendMail.aspx.cs:行号 72
//- (ERROR) 01/29 20:11:59,974
【发送邮件】发送邮件错误！
System.Exception: SWFUpload_0_0 不是 Int32 的有效值。 ---> System.FormatException: 输入字符串的格式不正确。
   在 System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   在 System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   在 System.ComponentModel.Int32Converter.FromString(String value, NumberFormatInfo formatInfo)
   在 System.ComponentModel.BaseNumberConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
   --- 内部异常堆栈跟踪的结尾 ---
   在 System.ComponentModel.BaseNumberConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.AssignToPropertyOrField(Object propertyValue, Object o, String memberName, JavaScriptSerializer serializer, Boolean throwOnError)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertDictionaryToObject(IDictionary`2 dictionary, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.AddItemToList(IList oldList, IList newList, Type elementType, JavaScriptSerializer serializer, Boolean throwOnError)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertListToObject(IList list, Type type, JavaScriptSerializer serializer, Boolean throwOnError, IList& convertedList)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeInternal(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.ObjectConverter.ConvertObjectToTypeMain(Object o, Type type, JavaScriptSerializer serializer, Boolean throwOnError, Object& convertedObject)
   在 System.Web.Script.Serialization.JavaScriptSerializer.Deserialize(JavaScriptSerializer serializer, String input, Type type, Int32 depthLimit)
   在 System.Web.Script.Serialization.JavaScriptSerializer.Deserialize[T](String input)
   在 WebMail2.Ctrs.Uploadify.GetFiles() 位置 f:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\Ctrs\Uploadify.ascx.cs:行号 26
   在 WebMail2.SendMail.SaveEmail(Boolean isDraft) 位置 f:\8、太阳雨新邮箱\WebMail2_sql2005\WebMail2\SendMail.aspx.cs:行号 72
//- (INFO) 01/29 20:22:02,106
----------------- 系统终止 -----------------
