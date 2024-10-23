window.renderDonutChart = (totalDebt, currentDebt, predictedDebt) => {
    const ctx = document.getElementById('donutChart').getContext('2d');

    const data = {
        labels: ['Total Debt', 'Current Debt', 'Predicted Debt End of Year'],
        datasets: [{
            data: [totalDebt, currentDebt, predictedDebt],
            backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56'],
            hoverBackgroundColor: ['#FF6384', '#36A2EB', '#FFCE56']
        }]
    };

    const options = {
        responsive: true,
        maintainAspectRatio: false,
    };

    new Chart(ctx, {
        type: 'doughnut',
        data: data,
        options: options
    });
};
