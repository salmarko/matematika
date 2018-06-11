var question = function () {

    var numericPadControl;

    function init() {
        _initComponents();
        _bindEvents();
    }

    function _initComponents() {
        numericPadControl = new numericPad();
        numericPadControl.init($("#Answer"));
    }

    function _bindEvents() {

    }

    return {
        init: init
    };
}();

$(function () {
    question.init();
});