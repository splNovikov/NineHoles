﻿(function () {
	'use strict'

	angular
		.module('gallery')
		.controller('GalleryController', [
			'$scope',
			'$window',
			GalleryCtrl])

	function GalleryCtrl(
		$scope,
		$window) {

		var defaultPath = 'Content/images/gallery/';

		$scope.$watch(function () {
			return $window.innerWidth;
		}, function (value) {
			var path;
			if (value < 450) {
				path = 'Content/images/gallery/mobile/';
			} else {
				path = defaultPath;
			}

			setImagePaths(path);
		});

		function setImagePaths(path) {
			$scope.imgPaths = [
			path + '01.jpg',
			path + '02.jpg',
			path + '03.jpg',
			path + '04.jpg',
			path + '05.jpg',
			path + '06.jpg',
			path + '07.jpg',
			path + '08.jpg',
			path + '09.jpg',
			path + '10.jpg',
			path + '11.jpg',
			path + '12.jpg',
			path + '13.jpg',
			path + '14.jpg',
			path + '15.jpg',
			path + '16.jpg',
			path + '17.jpg'
			]
		}

	}
})();