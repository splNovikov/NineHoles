(function () {
	'use strict'

	angular
		.module('places')
		.controller('PlacesController', [
			'$scope',
			PlacesCtrl])

	function PlacesCtrl(
		$scope) {

		$scope.map = {
			center: {
				latitude: 51.545997,
				longitude: 45.908891
			},
			zoom: 15,
			marker: {
				idKey: 1,
				coords: {
					latitude: 51.545997,
					longitude: 45.908891
				}
			}
		};

	}
})();