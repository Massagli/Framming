function Elemento() {

    var divRes = document.getElementById("favor")



    fetch("https://framming-api.onrender.com/users").then(resposta => {
        return resposta.json()
    }).then(corpo => {

        for (pos = 0; pos <= corpo.length; pos++) {
            var teste = document.createElement("p")
            divRes.appendChild(teste)
            teste.innerHTML = corpo[pos].nickUsuario
        }



        console.log(corpo.length)
        console.log(corpo[corpo.length - 1])
    })
}