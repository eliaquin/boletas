new Vue({
    el: "#app",
    data: {
        cartelera: {
            nombre: "",
            horario: "",
            precio: 0.00,
            fechaInicio: null,
            fechaFin: null
        },
        peliculas: []
    },
    methods: {
        guardar: function (model) {
            if (model === undefined || model === null)
                model = this.cartelera;
            var vm = this;
            axios.post("/api/boletas/guardarpelicula", model)
                .then(function (result) {
                    if (result.data) {
                        vm.cartelera.nombre = "";
                        vm.cartelera.horario = "";
                        vm.cartelera.precio = 0.00;
                        vm.cartelera.fechaInicio = null;
                        vm.cartelera.fechaFin = null;
                    }
                    vm.buscartodo();
                })
                .catch(function (error) {
                    console.log(error);
                });
        },
        buscartodo: function() {
            var vm = this;
            axios.get("/api/boletas/buscartodo")
                .then(function (result) {
                    vm.peliculas = result.data;
                })
                .catch(function (error) {
                    console.log(error);
                });
        },
        formatearFecha: function(fechajson) {
            return fechajson.split("T")[0];
        },
        formatearDinero: function(dinero) {
         return dinero.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, '$1,');
        }
    },
    computed: {

    },
    beforeMount: function () {
        this.buscartodo();
    }
});