/*
Navicat MySQL Data Transfer

Source Server         : test
Source Server Version : 100208
Source Host           : localhost:3306
Source Database       : zavrsni

Target Server Type    : MYSQL
Target Server Version : 100208
File Encoding         : 65001

Date: 2017-08-26 07:34:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for aukcije
-- ----------------------------
DROP TABLE IF EXISTS `aukcije`;
CREATE TABLE `aukcije` (
  `item` int(255) DEFAULT NULL,
  `owner` varchar(255) DEFAULT NULL,
  `realm` varchar(255) DEFAULT NULL,
  `bid` int(255) DEFAULT NULL,
  `buyout` int(255) DEFAULT NULL,
  `quantity` int(255) DEFAULT NULL,
  `cheaper` int(255) DEFAULT NULL,
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `auc` int(255) DEFAULT NULL,
  `date` datetime(6) DEFAULT NULL,
  `petSpeciesId` int(255) DEFAULT NULL,
  `petBreedId` int(255) DEFAULT NULL,
  `petLevel` int(255) DEFAULT NULL,
  `petQualityId` int(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16114661 DEFAULT CHARSET=utf8;
