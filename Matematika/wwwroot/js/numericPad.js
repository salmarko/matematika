var numericPad = function () {

    var _inputControl;

    function init(inputControl) {
        _inputControl = inputControl;
        _bindEvents();
    }

    function _bindEvents() {
        $(".numeric-pad").find("button").click(_onButtonClick);
    }

    function _onButtonClick() {
        _executeCommand($(this).data("id"));
    }

    function _executeCommand(key) {
        var currentValue = $(_inputControl).val();
        switch (key) {
            case -1:
                currentValue = currentValue.substring(0, currentValue.length - 1);
                $(_inputControl).val(currentValue);
                break;
            case -2:
                $("form").submit();
                break;
            default:
                currentValue += key;
                $(_inputControl).val(currentValue);
                break;
        }

    }

    return {
        init: init
    };
};