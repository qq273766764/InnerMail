/** 
        * 格式化整数 
        * @param number:number 要格式化的整数 
        * @param fmt:string 整数格式 
        */
function formatNumber(number, fmt) {
    number = number + '';
    if (fmt.length > number.length) {
        return fmt.substring(number.length) + number;
    }
    return number;
}

/** 
 * 格式化日期为字符串表示 
* @param datetime:Date 要格式化的日期对象 
* @param format:String 日期格式 
*/
function formatDate(datetime, format) {
    var cfg = {
        MMM: ['一', '二', '三', '四', '五', '六', '七', '八', '九', '十', '十一', '十二'],
        MMMM: ['一', '二', '三', '四', '五', '六', '七', '八', '九', '十', '十一', '十二']
    },
values = {
    y: datetime.getFullYear(),
    M: datetime.getMonth()+1,
    d: datetime.getDate(),
    H: datetime.getHours(),
    m: datetime.getMinutes(),
    s: datetime.getSeconds(),
    S: datetime.getMilliseconds()
};
    /*用正则表达式拆分日期格式各个元素*/
    var elems = format.match(/y+|M+|d+|H+|m+|s+|S+|[^yMdHmsS]/g);
    //将日期元素替换为实际的值 
    for (var i = 0; i < elems.length; i++) {
        if (cfg[elems[i]]) {
            elems[i] = cfg[elems[i]][values[elems[i].charAt(0)]];
        } else if (values[elems[i].charAt(0)]) {
            elems[i] = formatNumber(values[elems[i].charAt(0)], elems[i].replace(/./g, '0'));
        }
    }
    return elems.join('');
}
function ReadFormater(value, row) {
    return value ? "<img src='img/mailread.png' alt='已读'/>" : "<img id='isread" + row.ID + "' src='img/mailnotread.png' alt='未读'/>";
}
function DateFormater(value) {
    if (value == null) return "";
    var rValue = "";
    var date = new Date(Number(value.match(/\d+/)[0]));
    var year = date.getYear();
    if (year == new Date().getYear()) {
        rValue = formatDate(date, "MM月dd日 HH:mm");
    } else {
        rValue = formatDate(date, "yyyy年MM月dd日");
    }
    var Month = date.getMonth() + 1;
    rValue = rValue.replace("MM", Month > 10 ? Month : "0" + Month);
    rValue = rValue.replace("HH", "00");
    rValue = rValue.replace("mm", "00");
    return rValue;
}

function __doPostBack_Ex(eventTarget, eventArgument) {
    var theform;
    if (window.navigator.appName.toLowerCase().indexOf("netscape") > -1) {
        theform = document.forms[0];
    }
    else {
        theform = document.forms[0];
    }

    if (!theform.__EVENTTARGET) {
        theform.appendChild(document.createElement("<input type='hidden' name='__EVENTTARGET'>"));
    }

    if (!theform.__EVENTARGUMENT) {
        theform.appendChild(document.createElement("<input type='hidden' name='__EVENTARGUMENT'>"));
    }

    theform.__EVENTTARGET.value = eventTarget.split("$").join(":");
    theform.__EVENTARGUMENT.value = eventArgument;
    if ((typeof (theform.onsubmit) == "function")) {
        if (theform.onsubmit() != false) {
            theform.submit();
        }
    }
    else {
        theform.submit();
    }

    function __doPostBack(eventTarget, eventArgument) {
        __doPostBack_Ex(eventTarget, eventArgument);
    }
}

