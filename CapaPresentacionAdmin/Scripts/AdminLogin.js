function multipleBoxShadow(n) {
    let value = '';
    for (let i = 0; i < n; i++) {
        value += `${Math.floor(Math.random() * 2000)}px ${Math.floor(Math.random() * 2000)}px #FFF, `;
    }
    return value.slice(0, -2);
}

document.documentElement.style.setProperty('--shadows-small', multipleBoxShadow(700));
document.documentElement.style.setProperty('--shadows-medium', multipleBoxShadow(200));
document.documentElement.style.setProperty('--shadows-big', multipleBoxShadow(100));