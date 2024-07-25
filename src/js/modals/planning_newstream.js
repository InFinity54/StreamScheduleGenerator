import { format, parseISO, isFirstDayOfMonth } from 'date-fns';
import { fr } from 'date-fns/locale';

jQuery("#planning_newstream_modal_add").click(() => {
   if (jQuery('#planning_newstream_modal_form')[0].checkValidity()) {
      jQuery("#planning_newstream_modal_error").addClass("d-none");
      const bootstrap = require("bootstrap");
      const modal = bootstrap.Modal.getInstance(document.getElementById('planning_newstream_modal'));
      modal.toggle();

      createNewStream();
      resetModal();
   } else {
      var errorMessage = ``;
      jQuery("#planning_newstream_modal_error").removeClass("d-none");

      if (!jQuery("#planning_newstream_date")[0].validity.valid) {
         errorMessage += `La date du stream n'a pas été renseignée.`;
      }

      if (!jQuery("#planning_newstream_hour")[0].validity.valid) {
         if (errorMessage.length > 0) errorMessage += `<br />`;
         errorMessage += `L'heure de début du stream n'a pas été renseignée.`;
      }

      if (!jQuery("#planning_newstream_game_genshin")[0].checked && !jQuery("#planning_newstream_game_hunt")[0].checked && !jQuery("#planning_newstream_game_lol")[0].checked && !jQuery("#planning_newstream_game_valorant")[0].checked && !jQuery("#planning_newstream_game_wakfu")[0].checked) {
         if (errorMessage.length > 0) errorMessage += `<br />`;
         errorMessage += `Au moins un jeu doit être sélectionné pour ce stream.`;
      }

      jQuery("#planning_newstream_modal_error").html(errorMessage);
   }
});

function getStreamGameList() {
   var gameList = "";

   if (jQuery("#planning_newstream_game_genshin")[0].checked) {
      gameList += "genshin";
   }

   if (jQuery("#planning_newstream_game_hunt")[0].checked) {
      if (gameList.length > 0) gameList += `,`;
      gameList += "hunt";
   }

   if (jQuery("#planning_newstream_game_lol")[0].checked) {
      if (gameList.length > 0) gameList += `,`;
      gameList += "lol";
   }

   if (jQuery("#planning_newstream_game_valorant")[0].checked) {
      if (gameList.length > 0) gameList += `,`;
      gameList += "valorant";
   }

   if (jQuery("#planning_newstream_game_wakfu")[0].checked) {
      if (gameList.length > 0) gameList += `,`;
      gameList += "wakfu";
   }

   return gameList;
}

function formatDateToText(dateString) {
   // Convertir la chaîne de date en objet Date
   const date = parseISO(dateString);

   // Formater la date avec les options souhaitées
   let formattedDate = format(date, 'EEEE d MMMM yyyy', { locale: fr });

   // Ajouter "er" au premier jour du mois
   if (isFirstDayOfMonth(date)) {
      formattedDate = formattedDate.replace(' 1 ', ' 1er ');
   }

   return formattedDate.charAt(0).toUpperCase() + formattedDate.slice(1);
}

function createNewStream() {
   var gameList = getStreamGameList();

   // add new stream to stream list
   var streamDiv = jQuery('<div>', {
      class: 'col-sm-4',
      'data-stream-date': jQuery("#planning_newstream_date").val(),
      'data-stream-hour': jQuery("#planning_newstream_hour").val(),
      'data-stream-games': gameList
   });

   var cardDiv = jQuery('<div>', { class: 'card mb-2' }).appendTo(streamDiv);
   var cardBodyDiv = jQuery('<div>', { class: 'card-body' }).appendTo(cardDiv);

   jQuery('<h5>', {
      class: 'card-title',
      html: formatDateToText(jQuery("#planning_newstream_date").val()) + '<br />' + jQuery("#planning_newstream_hour").val().replace(":", "h")
   }).appendTo(cardBodyDiv);

   var cardTextDiv = jQuery('<div>', {
      class: 'card-text',
      html: 'Jeu(x) prévu(s) : '
   }).appendTo(cardBodyDiv);

   gameList.split(",").forEach(game => {
      jQuery('<div>', {
         class: 'planning_game_icon planning_game_icon_' + game
      }).appendTo(cardTextDiv);
   });

   var deleteButton = jQuery('<button>', {
      class: 'btn btn-danger',
      type: 'button',
      text: 'Supprimer ce stream'
   }).appendTo(cardBodyDiv);

   deleteButton.on('click', function() {
      streamDiv.remove();
   });

   jQuery('#planning_eventlist').append(streamDiv);
}

function resetModal() {
   jQuery("#planning_newstream_date").val("");
   jQuery("#planning_newstream_hour").val("");

   if (jQuery("#planning_newstream_game_genshin")[0].checked) {
      jQuery("#planning_newstream_game_genshin")[0].checked = false;
   }

   if (jQuery("#planning_newstream_game_hunt")[0].checked) {
      jQuery("#planning_newstream_game_hunt")[0].checked = false;
   }

   if (jQuery("#planning_newstream_game_lol")[0].checked) {
      jQuery("#planning_newstream_game_lol")[0].checked = false;
   }

   if (jQuery("#planning_newstream_game_valorant")[0].checked) {
      jQuery("#planning_newstream_game_valorant")[0].checked = false;
   }

   if (jQuery("#planning_newstream_game_wakfu")[0].checked) {
      jQuery("#planning_newstream_game_wakfu")[0].checked = false;
   }
}