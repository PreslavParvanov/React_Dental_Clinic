
export const ConvertDateTime_DDMMYYYY_HHMISS = (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);
    var ss = getSecondString(date);

    var dateString = dd + "/" + mm + "/" + yyyy + " " + hh + ":" + mi + ":" + ss;
    return dateString;
};

export const ConvertDateTime_AddDays_YYYYMMDD_HHMISS = (date, days) => {
    date.setDate(date.getDate() + days);
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);
    var ss = getSecondString(date);

    var dateString = yyyy + "-" + mm + "-" + dd + "T" + hh + ":" + mi + ":" + ss;


    return dateString;
};

export const ConvertDateTime_AddDays_YYYYMMDD_HHMI = (date, days) => {
    date.setDate(date.getDate() + days);
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);

    var dateString = yyyy + "-" + mm + "-" + dd + "T" + hh + ":" + mi;


    return dateString;
};

export const ConvertDateTime_AddDays_YYYYMMDD = (date, days) => {
    date.setDate(date.getDate() + days);
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();

    var dateString = yyyy + "-" + mm + "-" + dd;


    return dateString;
};

export const ConvertDateTime_DDMMYYYY_HHMI = (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);

    var dateString = dd + "/" + mm + "/" + yyyy + " " + hh + ":" + mi;
    return dateString;
};

export const ConvertDateTime_YYYYMMDD_HHMISS = (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);
    var ss = getSecondString(date);

    var dateString = yyyy + "-" + mm + "-" + dd + "T" + hh + ":" + mi + ":" + ss;
    return dateString;
};

export const ConvertDateTime_YYYYMMDD_HHMI = (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();
    var hh = getHourString(date);
    var mi = getMinuteString(date);

    var dateString = yyyy + "-" + mm + "-" + dd + "T" + hh + ":" + mi;
    return dateString;
};

export const ConvertDateTime_YYYYMMDD= (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();

    var dateString = yyyy + "-" + mm + "-" + dd ;
    return dateString;
};

export const ConvertDateTime_HHMI = (date) => {

    var hh = getHourString(date);
    var mi = getMinuteString(date);

    var dateString = hh + ":" + mi;
    return dateString;
};


export const ConvertDateTime_DDMMYYYY = (date) => {
    var dd = getDayString(date);
    var mm = getMonthString(date);
    var yyyy = date.getFullYear().toString();

    var dateString = dd + "/" + mm + "/" + yyyy;
    return dateString;
};



function getDayString(date) {
    var dd = date.getDate().toString();
    if (dd.length == 1) {
        dd = 0 + dd;
    }
    return dd;
}

function getMonthString(date) {
    var mm = (date.getMonth() + 1).toString();
    if (mm.length == 1) {
        mm = 0 + mm;
    }
    return mm;
}

function getHourString(date) {
    var hh = date.getHours().toString();
    if (hh.length == 1) {
        hh = 0 + hh;
    }
    return hh;
}

function getMinuteString(date) {
    var mi = date.getMinutes().toString();
    if (mi.length == 1) {
        mi = 0 + mi;
    }
    return mi;
}

function getSecondString(date) {
    var ss = date.getSeconds().toString();
    if (ss.length == 1) {
        ss = 0 + ss;
    }
    return ss;
}