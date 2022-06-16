window.addEventListener('load', () => {
    Init();
})

const Init = () => {
    trae_datos();
}

const trae_datos = async () => {
    const res = await fetch(url+"/api/Cliente");
    const datos = await res.json();
    console.log(datos);
}