const init = () => {
    const inputEmail = document.querySelector('input[type="email"]');
    const inputPassword = document.querySelector('input[type="password"]');
    const submitButton = document.querySelector('.btn');

    if (submitButton) {
        submitButton.addEventListener('click', (event) => {
            event.preventDefault();

            // Manual

            // if (inputEmail.value == "a@a" && inputPassword.value == "a" ) {
            //     location.href = "http://127.0.0.1:5500/Client/admin.html"
            // } else {
            //     alert("NÃO!")
            // }


            // Requisição por token

            fetch('https://reqres.in/api/login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    email: inputEmail.value,
                    password: inputPassword.value
                })
            }).then((response) => {
                return response.json();
            }).then((data) => {
                    console.log(data);
                //Imprementar validação e direcionar a página admin.html
            }).catch((e) => { e.message })
        })
    }
}

window.onload = init;