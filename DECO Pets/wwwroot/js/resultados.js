$document.addEventListener('DOMContentLoaded', function () {
    const selectOrdenarPor = document.getElementById('resultadosOrder');
    const container = document.querySelector('.row');

    selectOrdenarPor.addEventListener('change', function () {
        const ordenacao = selectOrdenarPor.value;

        const seguradoras = Array.from(container.querySelectorAll('.resultado_item'));

        seguradoras.sort((a, b) => {
            const precoA = parseFloat(a.querySelector('.price').textContent.replace('€', '').replace(',', '.'));
            const precoB = parseFloat(b.querySelector('.price').textContent.replace('€', '').replace(',', '.'));
            const qualidadeA = parseInt(a.getAttribute('data-filtroqualidade'));
            const qualidadeB = parseInt(b.getAttribute('data-filtroqualidade'));

            if (ordenacao === 'Qualidade') {
                return qualidadeB - qualidadeA; // Ordem decrescente
            } else if (ordenacao === 'Preço') {
                return precoA - precoB; // Ordem crescente
            }
        });

        seguradoras.forEach(seguradora => {
            container.appendChild(seguradora);
        });
    });
});