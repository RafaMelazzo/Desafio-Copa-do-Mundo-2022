const API_HOST = "https://localhost:44308/api/";

window.onload = async () => {
    const settings = {
        method: 'GET',
        headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json'
        }
    };

    try {
        const fetchClubes = await fetch(`${API_HOST}Clubes`, settings);
        const clubes = await fetchClubes.json();
        const fetchGrupos = await fetch(`${API_HOST}Grupos`, settings);
        const grupos = await fetchGrupos.json();
        const fetchPartidas = await fetch(`${API_HOST}Partidas`, settings);
        const partidas = await fetchPartidas.json();
        const fetchPartidasClubes = await fetch(`${API_HOST}PartidasClubes`, settings);
        const partidasClubes = await fetchPartidasClubes.json();
        
        console.log(clubes);
        console.log(grupos);
        console.log(partidas);
        console.log(partidasClubes);
        // let grupoId = "";
        // let html = "";


        // clubes.forEach(clube => {
        //     grupoId = `${clube.gruposId}` - 1;
        //     html += `
        // <tr>
        //     <td scope="row">${clube.id}</td>
        //     <td><img src="${clube.urlBandeira}" alt="Bandeira ${clube.nome}" width="40px" /></td>
        //     <td>${clube.nome}</td>
        //     <td>Grupo ${grupos[grupoId].nome}</td>
        //     <td>editar | excluir</td>
        // </tr>`

        // });

        // document.getElementById("f-oitavas").innerHTML = html;
    } catch (e) {
        console.log(e);
    }
}
