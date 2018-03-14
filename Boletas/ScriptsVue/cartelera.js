new Vue({
    el: "#app",
    data: {
        cartelera: {
            nombre: "",
            horario: "",
            precio: 0.00,
            fechaInicio: null,
            fechaFin: null
        }
    },
    methods: {
        guardar: function () {
            var vm = this;
            axios.post("/api/boletas/guardarpelicula", this.cartelera)
                .then(function (result) {
                    if (result.data) {
                        vm.cartelera.nombre = "";
                        vm.cartelera.horario = "";
                        vm.cartelera.precio = 0.00;
                        vm.cartelera.fechaInicio = null;
                        vm.cartelera.fechaFin = null;
                    }
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
    },
    computed: {

    },
    beforeMount: function () {

    }
});