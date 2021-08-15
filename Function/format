// JavaScript source code
function format() {
    var args = Array.prototype.slice.call(arguments, 1);
    return arguments[0].replace(/\{(\d+)\}/g, function (match, index) {
        return args[index];
    });
}

// Using
function showUsingFormat() {

    var cnt = 5;

    var msg = format('버튼의 cnt 값은 {0} 입니다.', cnt);
    alert(msg);

}

// Regular Expreesion

String.prototype.format = function() {
    var formatted = this, i = 0;
    while (/%s/.test(formatted))
    	formatted = formatted.replace("%s", arguments[i++]);
    return formatted;
}
console.log("%s + %s = %s".format(4, 5, 9));
