new Vue({
    el: "#app",
    data: {
        peliculas: [],
        peliculaSeleccionada: null
    },
    methods: {
        buscartodo: function () {
            var vm = this;
            axios.get("/api/boletas/buscartodo")
                .then(function (result) {
                    vm.peliculas = result.data;
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
    },
    computed: {
        tandas: function () {
            var vm = this;
            if (this.peliculaSeleccionada === null)
                return [];

            var res = this.peliculas.filter(function(el) {
                return el.Id === vm.peliculaSeleccionada;
            })[0];

            return res.Horario.split(",")
                .map(function(el) {
                    return el.trim();
                });
        }
    },
    beforeMount: function () {
        this.buscartodo();
    }
});