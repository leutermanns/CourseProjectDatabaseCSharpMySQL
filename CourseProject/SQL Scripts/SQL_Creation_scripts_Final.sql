SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema school database schema
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `school database schema` ;

-- -----------------------------------------------------
-- Schema school database schema
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `school database schema` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `school database schema` ;

-- -----------------------------------------------------
-- Table `school database schema`.`courses`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`courses` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`courses` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(254) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `summary` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NULL DEFAULT NULL,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Central course table'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`evidence`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`evidence` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`evidence` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `userid` BIGINT NOT NULL,
  `name` VARCHAR(100) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `description` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'The evidence of prior learning'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`groups_table`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`groups_table` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`groups_table` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `name` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL,
  `description` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NULL DEFAULT NULL,
  `active` BOOLEAN NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Group of users replacing the moodle cohort tables'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`skills`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`skills` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`skills` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NULL DEFAULT NULL,
  `description` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NULL DEFAULT NULL,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'This table contains the master record of each competency in '
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_courses_skills`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_courses_skills` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_courses_skills` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `course_id` BIGINT NOT NULL,
  `skill_id` BIGINT NOT NULL,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `grade` BIGINT(10) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `skillid_idx` (`skill_id` ASC) VISIBLE,
  INDEX `courseid_idx` (`course_id` ASC) VISIBLE,
  CONSTRAINT `FK_course_S`
    FOREIGN KEY (`course_id`)
    REFERENCES `school database schema`.`courses` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_skill_C`
    FOREIGN KEY (`skill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Link a competency to a course.'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_evidence_skills`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_evidence_skills` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_evidence_skills` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `evidence_id` BIGINT NOT NULL,
  `skill_id` BIGINT NOT NULL,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `grade` BIGINT(10) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `FK_evidence_idx` (`evidence_id` ASC) VISIBLE,
  INDEX `FK_skill_idx` (`skill_id` ASC) VISIBLE,
  CONSTRAINT `FK_evidence_S`
    FOREIGN KEY (`evidence_id`)
    REFERENCES `school database schema`.`evidence` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_skill_E`
    FOREIGN KEY (`skill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Relationship between user evidence and competencies'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_groups_table_skills`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_groups_table_skills` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_groups_table_skills` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `group_id` BIGINT NOT NULL,
  `skill_id` BIGINT NOT NULL,
  `grade` BIGINT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `FK_group_idx` (`group_id` ASC) VISIBLE,
  INDEX `FK_skill_idx` (`skill_id` ASC) VISIBLE,
  CONSTRAINT `FK_group_S`
    FOREIGN KEY (`group_id`)
    REFERENCES `school database schema`.`groups_table` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_skill_G`
    FOREIGN KEY (`skill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'list of skills required/desired before joining a group'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`users` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`users` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(100) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `password` VARCHAR(255) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `firstname` VARCHAR(100) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `lastname` VARCHAR(100) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `firstaccess` BIGINT NOT NULL DEFAULT '0',
  `lastaccess` BIGINT NOT NULL DEFAULT '0',
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'One record for each person'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_groups_table_users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_groups_table_users` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_groups_table_users` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `group_id` BIGINT NOT NULL,
  `user_id` BIGINT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `FK_group_idx` (`group_id` ASC) VISIBLE,
  INDEX `FK_user_idx` (`user_id` ASC) VISIBLE,
  CONSTRAINT `FK_group_U`
    FOREIGN KEY (`group_id`)
    REFERENCES `school database schema`.`groups_table` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_user_G`
    FOREIGN KEY (`user_id`)
    REFERENCES `school database schema`.`users` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Enrolment link for users as well as what percentage of their'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_skills_subskill`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_skills_subskill` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_skills_subskill` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `skill_id` BIGINT NOT NULL DEFAULT '0',
  `subskill_id` BIGINT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `FK_skill_idx` (`skill_id` ASC) VISIBLE,
  INDEX `FK_subskill_idx` (`subskill_id` ASC) VISIBLE,
  CONSTRAINT `FK_skill_S`
    FOREIGN KEY (`skill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_subskill`
    FOREIGN KEY (`subskill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_users_courses`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_users_courses` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_users_courses` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `course_id` BIGINT NOT NULL,
  `user_id` BIGINT NOT NULL,
  `timestart` BIGINT NOT NULL DEFAULT '0',
  `timeend` BIGINT NOT NULL DEFAULT '2147483647',
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`),
  INDEX `FK_course_idx` (`course_id` ASC) VISIBLE,
  INDEX `FK_user_idx` (`user_id` ASC) VISIBLE,
  CONSTRAINT `FK_course_U`
    FOREIGN KEY (`course_id`)
    REFERENCES `school database schema`.`courses` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_user_C`
    FOREIGN KEY (`user_id`)
    REFERENCES `school database schema`.`users` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'Users participating in courses (aka enrolled users) - everyb'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`link_users_skills`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`link_users_skills` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`link_users_skills` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `user_id` BIGINT NOT NULL,
  `skill_id` BIGINT NOT NULL,
  `grade` BIGINT NULL DEFAULT NULL,
  `timecreated`  TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `timemodified` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id`),
  INDEX `FK_user_idx` (`user_id` ASC) VISIBLE,
  INDEX `FK_skill_idx` (`skill_id` ASC) VISIBLE,
  CONSTRAINT `FK_user_S`
    FOREIGN KEY (`user_id`)
    REFERENCES `school database schema`.`users` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_skill_U`
    FOREIGN KEY (`skill_id`)
    REFERENCES `school database schema`.`skills` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'User competencies'
ROW_FORMAT = COMPRESSED;


-- -----------------------------------------------------
-- Table `school database schema`.`skill_categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `school database schema`.`skill_categories` ;

CREATE TABLE IF NOT EXISTS `school database schema`.`skill_categories` (
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `timecreated` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `training_category` VARCHAR(255) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_unicode_ci' NOT NULL DEFAULT '',
  `lower_bound` BIGINT NOT NULL,
  `upper_bound` BIGINT NOT NULL,
  `active` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci
COMMENT = 'This table is to hold the Skill level categories for reports'
ROW_FORMAT = COMPRESSED;

-- -----------------------------------------------------
-- Table Indecies to Improve Select Performance
-- Notes: Indecies already exist for many of the tables
-- this section has specific indecies for the most common
-- selections used by the application.
-- -----------------------------------------------------
-- User table
CREATE UNIQUE INDEX index_user_username_password ON users(id, username, password);

-- Courses Table
CREATE UNIQUE INDEX index_courses_coursename_courseid ON courses(id, name);

-- Skills Table
CREATE UNIQUE INDEX index_skills_id_name_description ON skills(id, name);

-- Skill Categories Table
CREATE UNIQUE INDEX index_skill_categories_id_active ON skill_categories(id, active);


-- -----------------------------------------------------
-- Triggers for updates to help keep accurate records
-- -----------------------------------------------------
DROP TRIGGER IF EXISTS `school database schema`.`users_update_trigger`;

DELIMITER //
CREATE TRIGGER users_update_trigger
	BEFORE UPDATE
		ON users FOR EACH ROW 
    BEGIN
		SET NEW.timemodified = current_timestamp();
END; //
DELIMITER ;

DROP TRIGGER IF EXISTS `school database schema`.`courses_update_trigger`;

DELIMITER //
CREATE TRIGGER courses_update_trigger
	BEFORE UPDATE
		ON courses FOR EACH ROW 
    BEGIN
		SET NEW.timemodified = CURRENT_TIMESTAMP();
END; //
DELIMITER ;

DROP TRIGGER IF EXISTS `school database schema`.`skills_update_trigger`;

DELIMITER //
CREATE TRIGGER skills_update_trigger
	BEFORE UPDATE
		ON skills FOR EACH ROW 
    BEGIN
		SET NEW.timemodified = CURRENT_TIMESTAMP();
END; //
DELIMITER ;

DROP TRIGGER IF EXISTS `school database schema`.`evidence_update_trigger`;

DELIMITER //
CREATE TRIGGER evidence_update_trigger
	BEFORE UPDATE
		ON evidence FOR EACH ROW 
    BEGIN
		SET NEW.timemodified = CURRENT_TIMESTAMP();
END; //
DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
