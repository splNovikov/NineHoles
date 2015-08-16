/// <reference path="../libs/angular/angular.js" />

(function () {
	'use strict';

	angular
		.module('nineHoles', [
			'ui.router',
			'uiGmapgoogle-maps',
			'angular-carousel',

			'main',
			'places'
		])

		.config([
			'$stateProvider',
			'$urlRouterProvider',

			function (
				$stateProvider,
				$urlRouterProvider) {

				var partialsPath = '/partials/';

				$urlRouterProvider.otherwise('/');

				$stateProvider
					// Main page FOR USER APPLICATION
					.state('index', {
						url: '/',
						templateUrl: partialsPath + 'main/index',
						controller: 'MainController as mainCtrl'
					})

					.state('minigolf', {
						url: '/minigolf',
						templateUrl: partialsPath + 'main/minigolf'
					})

					.state('places', {
						url: '/places',
						templateUrl: partialsPath + 'main/places',
						controller: 'PlacesController as placesCtrl'
					})

					.state('services', {
						url: '/services',
						templateUrl: partialsPath + 'main/services'
					})

					.state('gallery', {
						url: '/gallery',
						templateUrl: partialsPath + 'main/gallery'
					})

					.state('discounts', {
						url: '/discounts',
						templateUrl: partialsPath + 'main/discounts'
					})

			}])

})();