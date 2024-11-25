$(document).ready(function () {
    var $species = $("#ViewModels_SpeciesID");
    var $race = $("#ViewModels_RaceID");
    var $weightRow = $('#weightRow');
    var $weight = $('#weight');
    var $age = $('#age');


    $species.on('change', function () { 
        jQuery.ajax({
            url: "/Index?handler=Racas",
            type: "GET",
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: { id: $species.val() },
            success: function (data) {
                populateRaceDropdown(data);
            }
        });
    });

    function populateRaceDropdown(races) {
        $race.empty();
        $.each(races, function (index, race) {
            //var raceID = getRaceIDByName(raceName); // Obtém o ID da raça pelo nome
            $race.append($('<option>').text(race.descricao).val(race.id));
        });
        checkWeightRowVisibility();
        updateHiddenFields();
    }

    function checkWeightRowVisibility() {
        var selectedSpecies = $species.val();
        var selectedRace = $race.val();
        if (selectedSpecies === '1' && selectedRace === '1') {
            $weightRow.show();
        } else {
            $weightRow.hide();
        }
    }

    //function getRaceIDByName(raceName) {
    //    var species = $species.val();
    //    if (species === 'Cão') {
    //        var dogRacesToIDs = @Html.Raw(Json.Serialize(ViewData["DogRacesToIDs"]));
    //        return dogRacesToIDs[raceName.trim()]; // Obtém o ID da raça correspondente
    //    } else if (species === 'Gato') {
    //        var catRacesToIDs = @Html.Raw(Json.Serialize(ViewData["CatRacesToIDs"]));
    //        return catRacesToIDs[raceName.trim()]; // Obtém o ID da raça correspondente
    //    }
    //    return ''; // Retorna vazio se não encontrar correspondência
    //}

    $race.on('change', function () {
        checkWeightRowVisibility();
        updateHiddenFields();
    });

    function updateHiddenFields() {
        $('#selectedSpecies').val($species.val());
        $('#selectedRace').val($race.val());
        $('#selectedWeight').val($weight.val());
        $('#selectedAge').val($age.val());
    }
});