/////////// VALIDATION ///////////

function validateText(selector, minLength = 2) {
    try {
        const _element = document.querySelector(selector)
        _element.addEventListener('keyup', function () {

            if (_element.value.length == 0)
                setError(_element, `${_element.name} is required`)
            else if (_element.value.length < minLength)
                setError(_element, `${_element.name} must contain at least ${minLength} characters`)
            else
                setError(_element, '')
        })
    } catch { }
}
validateText("#name-input")
validateText("#message-input")


function setError(element, errorMsg) {
    const parent = element.parentNode
    const errorElement = parent.querySelector("small span")
    errorElement.innerText = errorMsg
}


function validateEmail(selector) {
    try {
        const _element = document.querySelector(selector)
        _element.addEventListener('keyup', function () {

            const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/

            if (_element.value.length == 0)
                setError(_element, `${_element.name} is required`)
            else if (!emailRegex.test(_element.value))
                setError(_element, `${_element.name} must be a valid email address`)
            else
                setError(_element, '')
        })
    } catch { }
}
validateEmail("#email-input")